
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Voice profile name or id. Falls back to per-client binding, then default.
    /// </summary>
    public sealed partial class SpeakRequestProfile
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}