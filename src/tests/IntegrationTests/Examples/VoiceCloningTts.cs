/*
order: 36
title: Voice Cloning TTS
slug: voice-cloning-tts

Generate speech from a cloned voice profile created at test time.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CloneVoiceAndGenerateSpeech()
    {
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
            //// Generate speech using the newly-created cloned profile.
            //// VOICEBOX_LANGUAGE defaults to ru, VOICEBOX_ENGINE defaults to qwen, and VOICEBOX_MODEL_SIZE defaults to 0.6B for faster local validation.
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

            generation.Id.Should().NotBeNullOrEmpty();
            generation.ProfileId.Should().Be(clonedVoice.Profile.Id);

            //// Voicebox generates asynchronously, so poll history until completion and then download the produced audio.
            var completed = await WaitForGenerationAsync(generation.Id);
            completed.Status.Should().Be("completed");
            completed.AudioPath.Should().NotBeNullOrEmpty();
            completed.Duration.Should().BeGreaterThan(0);

            var audio = await DownloadAudioAsync($"audio/{generation.Id}");
            audio.Bytes.Length.Should().BeGreaterThan(44);
            audio.ContentType?.MediaType.Should().StartWith("audio/");
        }
        finally
        {
            await TryDeleteGenerationAsync(generation?.Id);
            await TryDeleteProfileAsync(clonedVoice.Profile.Id);
        }
    }
}
