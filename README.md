<div class="docs-hero">
  <h1>Voicebox</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Voicebox generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/tryAGI.Voicebox/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/tryAGI.Voicebox"></a>
    <a href="https://github.com/tryAGI/Voicebox/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Voicebox/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Voicebox/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Voicebox"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from Voicebox's FastAPI OpenAPI schema, with a fallback to the checked-in docs schema, so the SDK tracks the upstream local API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Voicebox;

using var client = new VoiceboxClient();
// or: new VoiceboxClient(baseUri: new Uri("http://127.0.0.1:17493"));
```

<!-- EXAMPLES:START -->
### Health
Check a running Voicebox local server.

```csharp
var client = Client;

// Check whether the local Voicebox backend is available.
// The SDK defaults to http://127.0.0.1:17493, matching the desktop app backend port.
var health = await client.HealthHealthGetAsync();

Console.WriteLine($"Voicebox status: {health.Status}");
Console.WriteLine($"Backend: {health.BackendType ?? "unknown"}");
```

### Profiles
List voice profiles configured in Voicebox.

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

### Models
Inspect Voicebox model availability and download status.

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

### Generate Speech
Generate speech from text using an existing Voicebox profile.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Voicebox/issues">tryAGI/Voicebox</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Voicebox/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
