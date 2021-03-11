using System.Text.Json.Serialization;

namespace LocalAzureKeyVaultSpike.Models
{
    public class KeyResponse
    {
        [JsonPropertyName("key")]
        public JsonWebKeyModel Key { get; set; }

        [JsonPropertyName("attributes")]
        public KeyAttributesModel Attributes { get; set; }

        [JsonPropertyName("tags")]
        public object Tags { get; set; }
    }
}
