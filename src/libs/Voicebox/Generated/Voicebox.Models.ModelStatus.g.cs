
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for model status.
    /// </summary>
    public sealed partial class ModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Downloaded { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloading")]
        public bool? Downloading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_repo_id")]
        public string? HfRepoId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loaded")]
        public bool? Loaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_mb")]
        public double? SizeMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatus" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="downloaded"></param>
        /// <param name="modelName"></param>
        /// <param name="downloading">
        /// Default Value: false
        /// </param>
        /// <param name="hfRepoId"></param>
        /// <param name="loaded">
        /// Default Value: false
        /// </param>
        /// <param name="sizeMb"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelStatus(
            string displayName,
            bool downloaded,
            string modelName,
            bool? downloading,
            string? hfRepoId,
            bool? loaded,
            double? sizeMb)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Downloaded = downloaded;
            this.Downloading = downloading;
            this.HfRepoId = hfRepoId;
            this.Loaded = loaded;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.SizeMb = sizeMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatus" /> class.
        /// </summary>
        public ModelStatus()
        {
        }
    }
}