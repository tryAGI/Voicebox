namespace Voicebox.IntegrationTests;

[TestClass]
public partial class Tests
{
    private const string DefaultBaseUrl = "http://127.0.0.1:17493";

    private static VoiceboxClient _client = null!;

    public static VoiceboxClient Client => _client;

    public static string BaseUrl { get; private set; } = DefaultBaseUrl;

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        BaseUrl = GetOptionalEnvironmentVariable("VOICEBOX_BASE_URL") ?? DefaultBaseUrl;
        _client = new VoiceboxClient(
            baseUri: new Uri(BaseUrl),
            options: new AutoSDKClientOptions
            {
                Timeout = TimeSpan.FromSeconds(10),
            });

        try
        {
            _ = await _client.HealthHealthGetAsync();
        }
        catch (HttpRequestException e)
        {
            throw new AssertInconclusiveException(
                $"Voicebox server is not reachable at {BaseUrl}. Start Voicebox or set VOICEBOX_BASE_URL. {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new AssertInconclusiveException(
                $"Voicebox server did not respond at {BaseUrl}. Start Voicebox or set VOICEBOX_BASE_URL. {e.Message}");
        }
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        _client?.Dispose();
    }

    public static string? GetOptionalEnvironmentVariable(string name)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : null;
    }

    public static string GetRequiredEnvironmentVariable(string name)
    {
        return GetOptionalEnvironmentVariable(name)
            ?? throw new AssertInconclusiveException($"{name} environment variable is not found.");
    }
}
