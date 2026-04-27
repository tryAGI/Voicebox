# Profiles

List voice profiles configured in Voicebox.

This example assumes `using Voicebox;` is in scope and a Voicebox local server is running. The generated client defaults to `http://127.0.0.1:17493`.

```csharp
var client = Client;

// List the local Voicebox voice profiles.
// Profiles can be cloned voices, preset voices, or designed voices depending on the server setup.
var profiles = await client.ListProfilesProfilesGetAsync();

foreach (var profile in profiles.Take(5))
{
    Console.WriteLine($"{profile.Id}: {profile.Name} ({profile.Language})");
}
```