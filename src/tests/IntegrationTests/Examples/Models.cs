/*
order: 30
title: Models
slug: models

Inspect Voicebox model availability and download status.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetModelStatus()
    {
        var client = Client;

        //// Retrieve the server's model status list without loading a model.
        //// This is useful for checking which local TTS/STT assets are downloaded.
        var status = await client.GetModelStatusModelsStatusGetAsync();

        status.Should().NotBeNull();
        status.Models.Should().NotBeNull();

        foreach (var model in status.Models.Take(5))
        {
            Console.WriteLine($"{model.ModelName}: downloaded={model.Downloaded}, loaded={model.Loaded}");
        }
    }
}
