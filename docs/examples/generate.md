# Generate Speech

Generate speech from text using an existing Voicebox profile.

This example assumes `using Voicebox;` is in scope and a Voicebox local server is running. The generated client defaults to `http://127.0.0.1:17493`.

```csharp
var client = Client;

var profileId = GetRequiredEnvironmentVariable("VOICEBOX_PROFILE_ID");

// Generate speech from text with an existing voice profile.
// Set VOICEBOX_PROFILE_ID to the profile ID from your local Voicebox instance.
var generation = await client.GenerateSpeechGeneratePostAsync(
    new GenerationRequest
    {
        ProfileId = profileId,
        Text = "Voicebox is running locally from a generated .NET SDK.",
        Language = GetOptionalEnvironmentVariable("VOICEBOX_LANGUAGE") ?? "en",
        Engine = GetOptionalEnvironmentVariable("VOICEBOX_ENGINE") ?? "qwen",
        ModelSize = GetOptionalEnvironmentVariable("VOICEBOX_MODEL_SIZE") ?? "1.7B",
    });

Console.WriteLine($"Generated speech: {generation.Id}");
```