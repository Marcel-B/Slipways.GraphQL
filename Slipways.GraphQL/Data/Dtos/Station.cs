using System;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Data.Dtos
{
    public class Station
    {
        [JsonProperty("uuid")]
        public Guid Id { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("shortname")]
        public string Shortname { get; set; }
        [JsonProperty("longname")]
        public string Longname { get; set; }
        [JsonProperty("km")]
        public double Km { get; set; }
        [JsonProperty("agency")]
        public string Agency { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("water")]
        public Water Water { get; set; }
    }
}
