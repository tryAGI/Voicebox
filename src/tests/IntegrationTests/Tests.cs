namespace Voicebox.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VoiceboxTestEnvironment _environment = null!;
    private static VoiceboxClient _client = null!;

    public static VoiceboxClient Client => _client;

    public static string BaseUrl { get; private set; } = VoiceboxClient.DefaultBaseUrl;

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        _environment = await VoiceboxTestEnvironment.PrepareAsync();
        _client = _environment.Client;
        BaseUrl = _environment.BaseUri.ToString();

        context.WriteLine($"Voicebox integration tests using {_environment.Type} environment at {BaseUrl}");
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        if (_environment is not null)
        {
            _environment.DisposeAsync().AsTask().GetAwaiter().GetResult();
        }
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
