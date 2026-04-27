
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for updating a profile sample.
    /// </summary>
    public sealed partial class ProfileSampleUpdate
    {
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
        /// Initializes a new instance of the <see cref="ProfileSampleUpdate" /> class.
        /// </summary>
        /// <param name="referenceText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileSampleUpdate(
            string referenceText)
        {
            this.ReferenceText = referenceText ?? throw new global::System.ArgumentNullException(nameof(referenceText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileSampleUpdate" /> class.
        /// </summary>
        public ProfileSampleUpdate()
        {
        }
    }
}