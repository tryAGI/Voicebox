
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// A single effect in an effects chain.
    /// </summary>
    public sealed partial class EffectConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectConfig(
            string type,
            bool? enabled,
            object? @params)
        {
            this.Enabled = enabled;
            this.Params = @params;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectConfig" /> class.
        /// </summary>
        public EffectConfig()
        {
        }
    }
}