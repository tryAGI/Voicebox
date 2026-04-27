# Models

Inspect Voicebox model availability and download status.

This example assumes `using Voicebox;` is in scope and a Voicebox local server is running.

```csharp
var client = Client;

// Retrieve the server's model status list without loading a model.
// This is useful for checking which local TTS/STT assets are downloaded.
var status = await client.GetModelStatusModelsStatusGetAsync();

foreach (var model in status.Models.Take(5))
{
    Console.WriteLine($"{model.ModelName}: downloaded={model.Downloaded}, loaded={model.Loaded}");
}
```
