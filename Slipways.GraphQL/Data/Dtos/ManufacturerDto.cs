using System;
using System.Text.Json.Serialization;
using com.b_velop.Slipways.GrQl.Data.Models;

namespace com.b_velop.Slipways.GrQl.Data.Dtos
{
    public class ManufacturerDto
    {
        public ManufacturerDto() { }

        public ManufacturerDto(
            Manufacturer m)
        {
            Id = m.Id;
            Name = m.Name;
        }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
