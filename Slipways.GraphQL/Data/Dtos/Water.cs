using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GrQl.Data.Dtos
{
    public class Water
    {
        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("longname")]
        public string Longname { get; set; }
    }
}
