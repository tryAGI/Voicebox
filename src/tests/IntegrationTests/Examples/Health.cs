/*
order: 10
title: Health
slug: health

Check a running Voicebox local server.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CheckHealth()
    {
        var client = Client;

        //// Check whether the local Voicebox backend is available.
        //// The SDK defaults to http://127.0.0.1:17493, matching the desktop app backend port.
        var health = await client.General.HealthHealthGetAsync();

        health.Should().NotBeNull();
        health.Status.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Voicebox status: {health.Status}");
    }
}
