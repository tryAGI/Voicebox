# Voice Cloning

Create a cloned voice profile from reference audio, then optionally generate TTS with that profile.

This example assumes `using Voicebox;` is in scope and a Voicebox local server is running. The generated client defaults to `http://127.0.0.1:17493`.

```csharp
var client = Client;
var referenceAudio = GetReferenceAudio(requireExternalAudio: false);
VoiceProfileResponse? profile = null;

try
{
    // Create a temporary cloned voice profile.
    // Set VOICEBOX_REFERENCE_AUDIO_PATH to use a real 2-30 second voice clip; otherwise this test uses a generated WAV only for endpoint coverage.
    profile = await client.CreateProfileProfilesPostAsync(
        name: $"tryagi-sdk-e2e-{Guid.NewGuid():N}",
        description: "Temporary profile created by tryAGI.Voicebox integration tests.",
        language: TestLanguage,
        voiceType: "cloned",
        defaultEngine: TestEngine);

    // Attach reference voice audio and its transcript to the profile.
    var sample = await client.AddProfileSampleProfilesProfileIdSamplesPostAsync(
        profileId: profile.Id,
        file: referenceAudio.Bytes,
        filename: referenceAudio.Filename,
        referenceText: referenceAudio.ReferenceText);

    // Read the sample list back through the API and update the transcript.
    var samples = await client.GetProfileSamplesProfilesProfileIdSamplesGetAsync(profile.Id);

    var updatedReferenceText = $"{TestReferenceText} Updated.";
    var updatedSample = await client.UpdateProfileSampleProfilesSamplesSampleIdPutAsync(
        sampleId: sample.Id,
        referenceText: updatedReferenceText);

    // Download the stored sample audio to verify the binary audio endpoint.
    var sampleAudio = await DownloadAudioAsync($"samples/{sample.Id}");
}
finally
{
    await TryDeleteProfileAsync(profile?.Id);
}
```