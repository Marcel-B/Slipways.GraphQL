using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class Water
    {
        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("longname")]
        public string Longname { get; set; }
    }
}
