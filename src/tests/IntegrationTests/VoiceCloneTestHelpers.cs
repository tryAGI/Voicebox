using System.Diagnostics;
using System.Net.Http.Headers;

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    private const string DefaultLanguage = "ru";
    private const string DefaultEngine = "qwen";
    private const string DefaultModelSize = "0.6B";
    private const string DefaultReferenceText =
        "\u042d\u0442\u043e \u043a\u043e\u0440\u043e\u0442\u043a\u0438\u0439 \u043e\u0431\u0440\u0430\u0437\u0435\u0446 \u0433\u043e\u043b\u043e\u0441\u0430 \u0434\u043b\u044f \u043f\u0440\u043e\u0432\u0435\u0440\u043a\u0438 \u043a\u043b\u043e\u043d\u0438\u0440\u043e\u0432\u0430\u043d\u0438\u044f.";
    private const string DefaultGeneratedText =
        "\u041f\u0440\u0438\u0432\u0435\u0442! \u042d\u0442\u043e \u043f\u0440\u043e\u0432\u0435\u0440\u043a\u0430 \u0441\u0438\u043d\u0442\u0435\u0437\u0430 \u0440\u0435\u0447\u0438 \u043d\u043e\u0432\u044b\u043c \u0433\u043e\u043b\u043e\u0441\u043e\u043c.";

    private sealed record ReferenceAudio(byte[] Bytes, string Filename, string ReferenceText);

    private sealed record ClonedVoiceProfile(
        VoiceProfileResponse Profile,
        ProfileSampleResponse Sample);

    private static string TestLanguage =>
        GetOptionalEnvironmentVariable("VOICEBOX_LANGUAGE") ?? DefaultLanguage;

    private static string TestEngine =>
        GetOptionalEnvironmentVariable("VOICEBOX_ENGINE") ?? DefaultEngine;

    private static string TestModelSize =>
        GetOptionalEnvironmentVariable("VOICEBOX_MODEL_SIZE") ?? DefaultModelSize;

    private static string TestReferenceText =>
        GetOptionalEnvironmentVariable("VOICEBOX_REFERENCE_TEXT") ?? DefaultReferenceText;

    private static string TestGeneratedText =>
        GetOptionalEnvironmentVariable("VOICEBOX_TTS_TEXT") ?? DefaultGeneratedText;

    private static ReferenceAudio GetReferenceAudio(bool requireExternalAudio)
    {
        var referenceText = TestReferenceText;
        var audioPath = GetOptionalEnvironmentVariable("VOICEBOX_REFERENCE_AUDIO_PATH");
        if (audioPath is { Length: > 0 })
        {
            if (!File.Exists(audioPath))
            {
                throw new AssertInconclusiveException(
                    $"VOICEBOX_REFERENCE_AUDIO_PATH does not exist: {audioPath}");
            }

            return new ReferenceAudio(
                Bytes: File.ReadAllBytes(audioPath),
                Filename: Path.GetFileName(audioPath),
                ReferenceText: referenceText);
        }

        if (requireExternalAudio)
        {
            throw new AssertInconclusiveException(
                "Set VOICEBOX_REFERENCE_AUDIO_PATH to a 2-30 second reference voice sample for the full voice cloning TTS test.");
        }

        return new ReferenceAudio(
            Bytes: CreateReferenceWav(),
            Filename: "voicebox-reference.wav",
            ReferenceText: referenceText);
    }

    private static async Task<ClonedVoiceProfile> CreateClonedVoiceProfileAsync(
        bool requireExternalAudio)
    {
        var referenceAudio = GetReferenceAudio(requireExternalAudio);
        var profile = await Client.CreateProfileProfilesPostAsync(
            name: $"tryagi-sdk-e2e-{Guid.NewGuid():N}",
            description: "Temporary profile created by tryAGI.Voicebox integration tests.",
            language: TestLanguage,
            voiceType: "cloned",
            defaultEngine: TestEngine);

        try
        {
            var sample = await Client.AddProfileSampleProfilesProfileIdSamplesPostAsync(
                profileId: profile.Id,
                file: referenceAudio.Bytes,
                filename: referenceAudio.Filename,
                referenceText: referenceAudio.ReferenceText);

            return new ClonedVoiceProfile(profile, sample);
        }
        catch
        {
            await TryDeleteProfileAsync(profile.Id);
            throw;
        }
    }

    private static async Task<HistoryResponse> WaitForGenerationAsync(string generationId)
    {
        var timeoutSeconds =
            int.TryParse(GetOptionalEnvironmentVariable("VOICEBOX_TTS_TIMEOUT_SECONDS"), out var value)
                ? value
                : 600;
        var deadline = DateTimeOffset.UtcNow.AddSeconds(timeoutSeconds);

        while (DateTimeOffset.UtcNow < deadline)
        {
            var generation = await Client.GetGenerationHistoryGenerationIdGetAsync(generationId);
            var status = generation.Status ?? "completed";

            if (status.Equals("completed", StringComparison.OrdinalIgnoreCase))
            {
                return generation;
            }

            if (status.Equals("failed", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Fail($"Voicebox generation failed: {generation.Error ?? "unknown error"}");
            }

            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        Assert.Fail($"Voicebox generation {generationId} did not complete within {timeoutSeconds} seconds.");
        throw new UnreachableException();
    }

    private static async Task<(byte[] Bytes, MediaTypeHeaderValue? ContentType)> DownloadAudioAsync(string path)
    {
        using var response = await Client.HttpClient.GetAsync(path);
        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadAsByteArrayAsync(), response.Content.Headers.ContentType);
    }

    private static async Task TryDeleteGenerationAsync(string? generationId)
    {
        if (string.IsNullOrEmpty(generationId))
        {
            return;
        }

        try
        {
            _ = await Client.DeleteGenerationHistoryGenerationIdDeleteAsync(generationId);
        }
        catch (Exception e) when (e is HttpRequestException or InvalidOperationException or ApiException)
        {
        }
    }

    private static async Task TryDeleteProfileAsync(string? profileId)
    {
        if (string.IsNullOrEmpty(profileId))
        {
            return;
        }

        try
        {
            _ = await Client.DeleteProfileProfilesProfileIdDeleteAsync(profileId);
        }
        catch (Exception e) when (e is HttpRequestException or InvalidOperationException or ApiException)
        {
        }
    }

    private static byte[] CreateReferenceWav()
    {
        const int sampleRate = 16_000;
        const int bitsPerSample = 16;
        const int channelCount = 1;
        const double durationSeconds = 2.5;

        var sampleCount = (int)(sampleRate * durationSeconds);
        var dataSize = sampleCount * channelCount * bitsPerSample / 8;

        using var stream = new MemoryStream();
        using var writer = new BinaryWriter(stream);

        writer.Write("RIFF"u8);
        writer.Write(36 + dataSize);
        writer.Write("WAVE"u8);
        writer.Write("fmt "u8);
        writer.Write(16);
        writer.Write((short)1);
        writer.Write((short)channelCount);
        writer.Write(sampleRate);
        writer.Write(sampleRate * channelCount * bitsPerSample / 8);
        writer.Write((short)(channelCount * bitsPerSample / 8));
        writer.Write((short)bitsPerSample);
        writer.Write("data"u8);
        writer.Write(dataSize);

        for (var i = 0; i < sampleCount; i++)
        {
            var t = i / (double)sampleRate;
            var envelope = Math.Min(1.0, Math.Min(t / 0.05, (durationSeconds - t) / 0.05));
            var frequency = 180.0 + 80.0 * Math.Sin(2.0 * Math.PI * 1.7 * t);
            var sample = Math.Sin(2.0 * Math.PI * frequency * t) * envelope * 0.35;

            writer.Write((short)(sample * short.MaxValue));
        }

        return stream.ToArray();
    }
}
