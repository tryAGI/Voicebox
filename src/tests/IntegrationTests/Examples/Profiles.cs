/*
order: 20
title: Profiles
slug: profiles

List voice profiles configured in Voicebox.
*/

namespace Voicebox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListProfiles()
    {
        var client = Client;

        //// List the local Voicebox voice profiles.
        //// Profiles can be cloned voices, preset voices, or designed voices depending on the server setup.
        var profiles = await client.ListProfilesProfilesGetAsync();

        profiles.Should().NotBeNull();

        foreach (var profile in profiles.Take(5))
        {
            Console.WriteLine($"{profile.Id}: {profile.Name} ({profile.Language})");
        }
    }
}
