
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for profile sample.
    /// </summary>
    public sealed partial class ProfileSampleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

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
        /// Initializes a new instance of the <see cref="ProfileSampleResponse" /> class.
        /// </summary>
        /// <param name="audioPath"></param>
        /// <param name="id"></param>
        /// <param name="profileId"></param>
        /// <param name="referenceText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileSampleResponse(
            string audioPath,
            string id,
            string profileId,
            string referenceText)
        {
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.ReferenceText = referenceText ?? throw new global::System.ArgumentNullException(nameof(referenceText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileSampleResponse" /> class.
        /// </summary>
        public ProfileSampleResponse()
        {
        }
    }
}