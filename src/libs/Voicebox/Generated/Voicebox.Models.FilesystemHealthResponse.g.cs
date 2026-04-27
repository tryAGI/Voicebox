
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for filesystem health check.
    /// </summary>
    public sealed partial class FilesystemHealthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.DirectoryCheck> Directories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_free_mb")]
        public double? DiskFreeMb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_total_mb")]
        public double? DiskTotalMb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Healthy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemHealthResponse" /> class.
        /// </summary>
        /// <param name="directories"></param>
        /// <param name="healthy"></param>
        /// <param name="diskFreeMb"></param>
        /// <param name="diskTotalMb"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesystemHealthResponse(
            global::System.Collections.Generic.IList<global::Voicebox.DirectoryCheck> directories,
            bool healthy,
            double? diskFreeMb,
            double? diskTotalMb)
        {
            this.Directories = directories ?? throw new global::System.ArgumentNullException(nameof(directories));
            this.DiskFreeMb = diskFreeMb;
            this.DiskTotalMb = diskTotalMb;
            this.Healthy = healthy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesystemHealthResponse" /> class.
        /// </summary>
        public FilesystemHealthResponse()
        {
        }
    }
}