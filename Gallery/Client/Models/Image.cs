using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Gallery.Client.Models
{
    public class Image
    {
            [JsonProperty("asset_id")]
            public string AssetId { get; set; }

            [JsonProperty("public_id")]
            [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

            [JsonProperty("format")]
            public string Format { get; set; }

            [JsonProperty("version")]
            public int Version { get; set; }

            [JsonProperty("resource_type")]
            public string ResourceType { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("bytes")]
            public int Bytes { get; set; }

            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("secure_url")]
            public string SecureUrl { get; set; }
        }

}
