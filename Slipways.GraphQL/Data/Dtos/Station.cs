using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GrQl.Data.Dtos
{
    public class Station
    {
        [JsonProperty("uuid")]
        [JsonPropertyName("uuid")]
        public Guid Id { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("longname")]
        public string Longname { get; set; }

        [JsonPropertyName("km")]
        public double Km { get; set; }

        [JsonPropertyName("agency")]
        public string Agency { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("water")]
        public Water Water { get; set; }
    }
}
