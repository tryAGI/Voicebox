
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Description of an available effect type.
    /// </summary>
    public sealed partial class AvailableEffect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Params { get; set; }

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
        /// Initializes a new instance of the <see cref="AvailableEffect" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="label"></param>
        /// <param name="params"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableEffect(
            string description,
            string label,
            object @params,
            string type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableEffect" /> class.
        /// </summary>
        public AvailableEffect()
        {
        }
    }
}