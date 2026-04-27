
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for LLM text generation.
    /// </summary>
    public sealed partial class LLMGenerateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Examples { get; set; }

        /// <summary>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 0.6B
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_size")]
        public string? ModelSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGenerateRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="examples"></param>
        /// <param name="maxTokens">
        /// Default Value: 512
        /// </param>
        /// <param name="modelSize">
        /// Default Value: 0.6B
        /// </param>
        /// <param name="system"></param>
        /// <param name="temperature">
        /// Default Value: 0.7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMGenerateRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? examples,
            int? maxTokens,
            string? modelSize,
            string? system,
            double? temperature)
        {
            this.Examples = examples;
            this.MaxTokens = maxTokens;
            this.ModelSize = modelSize;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.System = system;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGenerateRequest" /> class.
        /// </summary>
        public LLMGenerateRequest()
        {
        }
    }
}