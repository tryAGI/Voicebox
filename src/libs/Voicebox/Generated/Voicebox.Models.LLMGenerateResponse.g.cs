
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for LLM text generation.
    /// </summary>
    public sealed partial class LLMGenerateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGenerateResponse" /> class.
        /// </summary>
        /// <param name="modelSize"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMGenerateResponse(
            string modelSize,
            string text)
        {
            this.ModelSize = modelSize ?? throw new global::System.ArgumentNullException(nameof(modelSize));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGenerateResponse" /> class.
        /// </summary>
        public LLMGenerateResponse()
        {
        }
    }
}