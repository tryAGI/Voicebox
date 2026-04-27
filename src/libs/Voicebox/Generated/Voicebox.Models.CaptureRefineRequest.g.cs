
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request to refine a capture's transcript via the LLM.
    /// </summary>
    public sealed partial class CaptureRefineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::Voicebox.RefinementFlagsModel? Flags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_size")]
        public string? ModelSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRefineRequest" /> class.
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="modelSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptureRefineRequest(
            global::Voicebox.RefinementFlagsModel? flags,
            string? modelSize)
        {
            this.Flags = flags;
            this.ModelSize = modelSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRefineRequest" /> class.
        /// </summary>
        public CaptureRefineRequest()
        {
        }
    }
}