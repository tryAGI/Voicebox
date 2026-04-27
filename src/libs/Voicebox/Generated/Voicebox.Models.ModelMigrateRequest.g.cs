
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for migrating models to a new directory.
    /// </summary>
    public sealed partial class ModelMigrateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMigrateRequest" /> class.
        /// </summary>
        /// <param name="destination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelMigrateRequest(
            string destination)
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMigrateRequest" /> class.
        /// </summary>
        public ModelMigrateRequest()
        {
        }
    }
}