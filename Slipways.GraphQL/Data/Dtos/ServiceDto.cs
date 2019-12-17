using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using com.b_velop.Slipways.GrQl.Data.Models;

namespace com.b_velop.Slipways.GrQl.Data.Dtos
{
    public class ServiceDto
    {
        public ServiceDto() { }

        public ServiceDto(
            Service s)
        {
            Id = s.Id;
            Name = s.Name;

            Street = s.Street;
            Postalcode = s.Postalcode;
            City = s.City;

            Longitude = s.Longitude;
            Latitude = s.Latitude;

            Url = s.Url;
            Phone = s.Phone;
            Email = s.Email;

            Manufacturers = new HashSet<ManufacturerDto>();

            if (s.Manufacturers == null)
                return;

            foreach (var manufacturer in s.Manufacturers)
                Manufacturers.Add(new ManufacturerDto(manufacturer));
        }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("postalcode")]
        public string Postalcode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }


        [JsonPropertyName("manufacturers")]
        public HashSet<ManufacturerDto> Manufacturers { get; set; }
    }
}
