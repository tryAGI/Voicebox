
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Health status for a single directory.
    /// </summary>
    public sealed partial class DirectoryCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Exists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Writable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCheck" /> class.
        /// </summary>
        /// <param name="exists"></param>
        /// <param name="path"></param>
        /// <param name="writable"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryCheck(
            bool exists,
            string path,
            bool writable,
            string? error)
        {
            this.Error = error;
            this.Exists = exists;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Writable = writable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCheck" /> class.
        /// </summary>
        public DirectoryCheck()
        {
        }
    }
}