# Voice Cloning TTS

Generate speech from a cloned voice profile created at test time.

This example assumes `using Voicebox;` is in scope and a Voicebox local server is running. The generated client defaults to `http://127.0.0.1:17493`.

```csharp
if (!bool.TryParse(GetOptionalEnvironmentVariable("VOICEBOX_RUN_TTS_E2E"), out var runE2E) || !runE2E)
{
    throw new AssertInconclusiveException(
        "Set VOICEBOX_RUN_TTS_E2E=true and VOICEBOX_REFERENCE_AUDIO_PATH to run the full voice cloning TTS test.");
}

var client = Client;
var clonedVoice = await CreateClonedVoiceProfileAsync(requireExternalAudio: true);
GenerationResponse? generation = null;

try
{
    // Generate speech using the newly-created cloned profile.
    // VOICEBOX_LANGUAGE defaults to ru, VOICEBOX_ENGINE defaults to qwen, and VOICEBOX_MODEL_SIZE defaults to 0.6B for faster local validation.
    generation = await client.GenerateSpeechGeneratePostAsync(
        new GenerationRequest
        {
            ProfileId = clonedVoice.Profile.Id,
            Text = TestGeneratedText,
            Language = TestLanguage,
            Engine = TestEngine,
            ModelSize = TestModelSize,
            Seed = 1,
            Normalize = true,
            MaxChunkChars = 300,
        });

    // Voicebox generates asynchronously, so poll history until completion and then download the produced audio.
    var completed = await WaitForGenerationAsync(generation.Id);

    var audio = await DownloadAudioAsync($"audio/{generation.Id}");
}
finally
{
    await TryDeleteGenerationAsync(generation?.Id);
    await TryDeleteProfileAsync(clonedVoice.Profile.Id);
}
```