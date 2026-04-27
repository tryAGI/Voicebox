
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateCaptureEndpointCapturesPost
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
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Default Value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_model")]
        public string? SttModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateCaptureEndpointCapturesPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="language"></param>
        /// <param name="source">
        /// Default Value: file
        /// </param>
        /// <param name="sttModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateCaptureEndpointCapturesPost(
            byte[] file,
            string filename,
            string? language,
            string? source,
            string? sttModel)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Language = language;
            this.Source = source;
            this.SttModel = sttModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateCaptureEndpointCapturesPost" /> class.
        /// </summary>
        public BodyCreateCaptureEndpointCapturesPost()
        {
        }
    }
}