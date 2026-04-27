# Health

Check a running Voicebox local server.

This example assumes `using Voicebox;` is in scope and a Voicebox local server is running.

```csharp
var client = Client;

// Check whether the local Voicebox backend is available.
// The SDK defaults to http://127.0.0.1:17493, matching the desktop app backend port.
var health = await client.HealthHealthGetAsync();

Console.WriteLine($"Voicebox status: {health.Status}");
Console.WriteLine($"Backend: {health.BackendType ?? "unknown"}");
```
