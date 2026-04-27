
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for health check.
    /// </summary>
    public sealed partial class HealthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend_type")]
        public string? BackendType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend_variant")]
        public string? BackendVariant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GpuAvailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_compatibility_warning")]
        public string? GpuCompatibilityWarning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        public string? GpuType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_downloaded")]
        public bool? ModelDownloaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_loaded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ModelLoaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_size")]
        public string? ModelSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vram_used_mb")]
        public double? VramUsedMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        /// <param name="gpuAvailable"></param>
        /// <param name="modelLoaded"></param>
        /// <param name="status"></param>
        /// <param name="backendType"></param>
        /// <param name="backendVariant"></param>
        /// <param name="gpuCompatibilityWarning"></param>
        /// <param name="gpuType"></param>
        /// <param name="modelDownloaded"></param>
        /// <param name="modelSize"></param>
        /// <param name="vramUsedMb"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthResponse(
            bool gpuAvailable,
            bool modelLoaded,
            string status,
            string? backendType,
            string? backendVariant,
            string? gpuCompatibilityWarning,
            string? gpuType,
            bool? modelDownloaded,
            string? modelSize,
            double? vramUsedMb)
        {
            this.BackendType = backendType;
            this.BackendVariant = backendVariant;
            this.GpuAvailable = gpuAvailable;
            this.GpuCompatibilityWarning = gpuCompatibilityWarning;
            this.GpuType = gpuType;
            this.ModelDownloaded = modelDownloaded;
            this.ModelLoaded = modelLoaded;
            this.ModelSize = modelSize;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.VramUsedMb = vramUsedMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        public HealthResponse()
        {
        }
    }
}