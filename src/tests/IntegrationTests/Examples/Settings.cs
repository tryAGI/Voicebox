/*
order: 50
title: Settings
slug: settings

Read Voicebox server-side generation and capture defaults.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetCaptureSettings()
    {
        var client = Client;

        //// Read persisted defaults for dictation, transcription, and transcript refinement.
        var settings = await client.GetCaptureSettingsEndpointSettingsCapturesGetAsync();

        settings.Should().NotBeNull();

        Console.WriteLine($"STT model: {settings.SttModel}");
        Console.WriteLine($"Auto-refine: {settings.AutoRefine}");
    }

    [TestMethod]
    public async Task GetGenerationSettings()
    {
        var client = Client;

        //// Read persisted defaults for speech generation.
        var settings = await client.GetGenerationSettingsEndpointSettingsGenerationGetAsync();

        settings.Should().NotBeNull();

        Console.WriteLine($"Max chunk chars: {settings.MaxChunkChars}");
        Console.WriteLine($"Crossfade: {settings.CrossfadeMs}ms");
    }
}
