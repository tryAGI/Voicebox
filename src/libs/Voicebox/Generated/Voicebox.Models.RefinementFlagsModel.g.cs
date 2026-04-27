
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Boolean toggles that drive the refinement prompt builder.
    /// </summary>
    public sealed partial class RefinementFlagsModel
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_technical")]
        public bool? PreserveTechnical { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_correction")]
        public bool? SelfCorrection { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_cleanup")]
        public bool? SmartCleanup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefinementFlagsModel" /> class.
        /// </summary>
        /// <param name="preserveTechnical">
        /// Default Value: true
        /// </param>
        /// <param name="selfCorrection">
        /// Default Value: true
        /// </param>
        /// <param name="smartCleanup">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefinementFlagsModel(
            bool? preserveTechnical,
            bool? selfCorrection,
            bool? smartCleanup)
        {
            this.PreserveTechnical = preserveTechnical;
            this.SelfCorrection = selfCorrection;
            this.SmartCleanup = smartCleanup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefinementFlagsModel" /> class.
        /// </summary>
        public RefinementFlagsModel()
        {
        }
    }
}