
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for active download task.
    /// </summary>
    public sealed partial class ActiveDownloadTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public int? Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDownloadTask" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="current"></param>
        /// <param name="error"></param>
        /// <param name="filename"></param>
        /// <param name="progress"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveDownloadTask(
            string modelName,
            global::System.DateTime startedAt,
            string status,
            int? current,
            string? error,
            string? filename,
            double? progress,
            int? total)
        {
            this.Current = current;
            this.Error = error;
            this.Filename = filename;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Progress = progress;
            this.StartedAt = startedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDownloadTask" /> class.
        /// </summary>
        public ActiveDownloadTask()
        {
        }
    }
}