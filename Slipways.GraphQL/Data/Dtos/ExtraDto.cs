using System;
using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GrQl.Data.Dtos
{
    public class ExtraDto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
