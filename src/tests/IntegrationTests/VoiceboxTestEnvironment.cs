using DotNet.Testcontainers;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using DotNet.Testcontainers.Images;

namespace Voicebox.IntegrationTests;

public sealed class VoiceboxTestEnvironment : IAsyncDisposable
{
    private const ushort VoiceboxPort = 17493;
    private const string DefaultBaseUrl = "http://127.0.0.1:17493";
    private static readonly TimeSpan ClientTimeout = TimeSpan.FromMinutes(20);
    private static readonly TimeSpan ImageBuildTimeout = TimeSpan.FromMinutes(60);
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(10);

    public required VoiceboxTestEnvironmentType Type { get; init; }
    public required VoiceboxClient Client { get; init; }
    public IContainer? Container { get; init; }
    public IFutureDockerImage? Image { get; init; }

    public Uri BaseUri => Client.BaseUri ?? new Uri(DefaultBaseUrl);

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();

        if (Container is not null)
        {
            await Container.DisposeAsync();
        }

        if (Image is not null)
        {
            await Image.DeleteAsync(CancellationToken.None);
        }
    }

    public static async Task<VoiceboxTestEnvironment> PrepareAsync(
        VoiceboxTestEnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();

        return environmentType switch
        {
            VoiceboxTestEnvironmentType.Local => await PrepareLocalAsync(),
            VoiceboxTestEnvironmentType.Container => await PrepareContainerAsync(),
            _ => throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null),
        };
    }

    private static async Task<VoiceboxTestEnvironment> PrepareLocalAsync()
    {
        var baseUrl = GetOptionalEnvironmentVariable("VOICEBOX_BASE_URL") ?? DefaultBaseUrl;
        var client = CreateClient(new Uri(baseUrl));

        await CheckHealthAsync(client, baseUrl);

        return new VoiceboxTestEnvironment
        {
            Type = VoiceboxTestEnvironmentType.Local,
            Client = client,
        };
    }

    private static async Task<VoiceboxTestEnvironment> PrepareContainerAsync()
    {
        IFutureDockerImage? image = null;
        IImage containerImage;

        var imageName = GetOptionalEnvironmentVariable("VOICEBOX_TESTCONTAINERS_IMAGE");
        var contextDirectory = GetOptionalEnvironmentVariable("VOICEBOX_TESTCONTAINERS_CONTEXT");

        if (imageName is { Length: > 0 })
        {
            containerImage = new DockerImage(imageName);
        }
        else if (contextDirectory is { Length: > 0 })
        {
            var fullContextDirectory = Path.GetFullPath(contextDirectory);
            if (!Directory.Exists(fullContextDirectory))
            {
                throw new AssertInconclusiveException(
                    $"VOICEBOX_TESTCONTAINERS_CONTEXT does not exist: {fullContextDirectory}");
            }

            image = new ImageFromDockerfileBuilder()
                .WithName($"localhost/tryagi-voicebox-tests:{Guid.NewGuid():N}")
                .WithDockerfile("Dockerfile")
                .WithDockerfileDirectory(fullContextDirectory)
                .WithContextDirectory(fullContextDirectory)
                .Build();

            using var buildCts = new CancellationTokenSource(ImageBuildTimeout);
            await image.CreateAsync(buildCts.Token);
            containerImage = image;
        }
        else
        {
            throw new AssertInconclusiveException(
                "Container tests require VOICEBOX_TESTCONTAINERS_IMAGE or VOICEBOX_TESTCONTAINERS_CONTEXT.");
        }

        var container = new ContainerBuilder(containerImage)
            .WithEnvironment("LOG_LEVEL", "info")
            .WithEnvironment("NUMBA_CACHE_DIR", "/tmp/numba_cache")
            .WithPortBinding(VoiceboxPort, assignRandomHostPort: true)
            .WithWaitStrategy(
                Wait.ForUnixContainer()
                    .UntilHttpRequestIsSucceeded(request => request
                        .ForPath("/health")
                        .ForPort(VoiceboxPort)))
            .Build();

        using var startupCts = new CancellationTokenSource(StartupTimeout);
        await container.StartAsync(startupCts.Token);

        var baseUri = new UriBuilder(
            Uri.UriSchemeHttp,
            container.Hostname,
            container.GetMappedPublicPort(VoiceboxPort)).Uri;

        var client = CreateClient(baseUri);
        await CheckHealthAsync(client, baseUri.ToString());

        return new VoiceboxTestEnvironment
        {
            Type = VoiceboxTestEnvironmentType.Container,
            Client = client,
            Container = container,
            Image = image,
        };
    }

    private static VoiceboxClient CreateClient(Uri baseUri) =>
        new(
            httpClient: new HttpClient
            {
                Timeout = ClientTimeout,
                BaseAddress = baseUri,
            },
            options: new AutoSDKClientOptions
            {
                Timeout = ClientTimeout,
            });

    private static async Task CheckHealthAsync(VoiceboxClient client, string baseUrl)
    {
        try
        {
            _ = await client.HealthHealthGetAsync();
        }
        catch (HttpRequestException e)
        {
            throw new AssertInconclusiveException(
                $"Voicebox server is not reachable at {baseUrl}. Start Voicebox, set VOICEBOX_BASE_URL, or set VOICEBOX_TEST_ENVIRONMENT=Container. {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new AssertInconclusiveException(
                $"Voicebox server did not respond at {baseUrl}. Start Voicebox, set VOICEBOX_BASE_URL, or set VOICEBOX_TEST_ENVIRONMENT=Container. {e.Message}");
        }
    }

    private static VoiceboxTestEnvironmentType InferEnvironment()
    {
        var rawEnvironment = GetOptionalEnvironmentVariable("VOICEBOX_TEST_ENVIRONMENT");
        if (rawEnvironment is not null)
        {
            if (rawEnvironment.Equals("local", StringComparison.OrdinalIgnoreCase))
            {
                return VoiceboxTestEnvironmentType.Local;
            }

            if (rawEnvironment.Equals("container", StringComparison.OrdinalIgnoreCase) ||
                rawEnvironment.Equals("testcontainers", StringComparison.OrdinalIgnoreCase) ||
                rawEnvironment.Equals("docker", StringComparison.OrdinalIgnoreCase))
            {
                return VoiceboxTestEnvironmentType.Container;
            }

            if (!rawEnvironment.Equals("auto", StringComparison.OrdinalIgnoreCase))
            {
                throw new AssertInconclusiveException(
                    $"Unsupported VOICEBOX_TEST_ENVIRONMENT value: {rawEnvironment}");
            }
        }

        return GetOptionalEnvironmentVariable("VOICEBOX_TESTCONTAINERS_IMAGE") is not null ||
               GetOptionalEnvironmentVariable("VOICEBOX_TESTCONTAINERS_CONTEXT") is not null
            ? VoiceboxTestEnvironmentType.Container
            : VoiceboxTestEnvironmentType.Local;
    }

    private static string? GetOptionalEnvironmentVariable(string name) =>
        System.Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : null;
}

public enum VoiceboxTestEnvironmentType
{
    Local,
    Container,
}
