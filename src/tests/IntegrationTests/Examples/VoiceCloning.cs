/*
order: 35
title: Voice Cloning
slug: voice-cloning

Create a cloned voice profile from reference audio, then optionally generate TTS with that profile.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateClonedVoiceProfileWithSample()
    {
        var client = Client;
        var referenceAudio = GetReferenceAudio(requireExternalAudio: false);
        VoiceProfileResponse? profile = null;

        try
        {
            //// Create a temporary cloned voice profile.
            //// Set VOICEBOX_REFERENCE_AUDIO_PATH to use a real 2-30 second voice clip; otherwise this test uses a generated WAV only for endpoint coverage.
            profile = await client.Profiles.CreateProfileProfilesPostAsync(
                name: $"tryagi-sdk-e2e-{Guid.NewGuid():N}",
                description: "Temporary profile created by tryAGI.Voicebox integration tests.",
                language: TestLanguage);

            profile.Id.Should().NotBeNullOrEmpty();
            profile.Language.Should().Be(TestLanguage);

            //// Attach reference voice audio and its transcript to the profile.
            var sample = await client.Profiles.AddProfileSampleProfilesProfileIdSamplesPostAsync(
                profileId: profile.Id,
                file: referenceAudio.Bytes,
                filename: referenceAudio.Filename,
                referenceText: referenceAudio.ReferenceText);

            sample.Id.Should().NotBeNullOrEmpty();
            sample.ProfileId.Should().Be(profile.Id);
            sample.ReferenceText.Should().Be(TestReferenceText);

            //// Read the sample list back through the API.
            var samples = await client.Profiles.GetProfileSamplesProfilesProfileIdSamplesGetAsync(profile.Id);
            samples.Select(x => x.Id).Should().Contain(sample.Id);

            //// Download the stored sample audio to verify the binary audio endpoint.
            var sampleAudio = await DownloadAudioAsync($"samples/{sample.Id}");
            sampleAudio.Bytes.Length.Should().BeGreaterThan(44);
            sampleAudio.ContentType?.MediaType.Should().StartWith("audio/");
        }
        finally
        {
            await TryDeleteProfileAsync(profile?.Id);
        }
    }
}
