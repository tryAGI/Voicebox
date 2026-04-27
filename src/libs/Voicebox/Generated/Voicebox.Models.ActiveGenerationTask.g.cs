
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for active generation task.
    /// </summary>
    public sealed partial class ActiveGenerationTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPreview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveGenerationTask" /> class.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="startedAt"></param>
        /// <param name="taskId"></param>
        /// <param name="textPreview"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveGenerationTask(
            string profileId,
            global::System.DateTime startedAt,
            string taskId,
            string textPreview)
        {
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.StartedAt = startedAt;
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.TextPreview = textPreview ?? throw new global::System.ArgumentNullException(nameof(textPreview));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveGenerationTask" /> class.
        /// </summary>
        public ActiveGenerationTask()
        {
        }
    }
}