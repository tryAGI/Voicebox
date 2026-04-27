/*
order: 40
title: Generate Speech
slug: generate

Generate speech from text using an existing Voicebox profile.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Generate()
    {
        var client = Client;

        var profileId = GetRequiredEnvironmentVariable("VOICEBOX_PROFILE_ID");

        //// Generate speech from text with an existing voice profile.
        //// Set VOICEBOX_PROFILE_ID to the profile ID from your local Voicebox instance.
        var generation = await client.GenerateSpeechGeneratePostAsync(
            new GenerationRequest
            {
                ProfileId = profileId,
                Text = "Voicebox is running locally from a generated .NET SDK.",
                Language = GetOptionalEnvironmentVariable("VOICEBOX_LANGUAGE") ?? "en",
                Engine = GetOptionalEnvironmentVariable("VOICEBOX_ENGINE") ?? "qwen",
                ModelSize = GetOptionalEnvironmentVariable("VOICEBOX_MODEL_SIZE") ?? "1.7B",
            });

        generation.Should().NotBeNull();
        generation.Id.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Generated speech: {generation.Id}");
    }
}
