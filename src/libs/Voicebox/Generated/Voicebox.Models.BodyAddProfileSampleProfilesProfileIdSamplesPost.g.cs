
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddProfileSampleProfilesProfileIdSamplesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddProfileSampleProfilesProfileIdSamplesPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="referenceText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddProfileSampleProfilesProfileIdSamplesPost(
            byte[] file,
            string filename,
            string referenceText)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ReferenceText = referenceText ?? throw new global::System.ArgumentNullException(nameof(referenceText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddProfileSampleProfilesProfileIdSamplesPost" /> class.
        /// </summary>
        public BodyAddProfileSampleProfilesProfileIdSamplesPost()
        {
        }
    }
}