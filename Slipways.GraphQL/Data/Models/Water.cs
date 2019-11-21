using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace com.b_velop.Slipways.GraphQL.Data.Models
{
    public class Water : IEntity
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }

        [JsonPropertyName("longname")]
        public string Longname { get; set; }
    }
}
