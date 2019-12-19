using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.b_velop.Slipways.GrQl.Data.Dtos;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Service : Locationable
    {
        public Service()
        {
            Manufacturers = new List<Manufacturer>();
        }

        public Service(
            ServiceDto s) : this()
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
            Manufacturers = new List<Manufacturer>();
            if (s.Manufacturers == null)
                return;
            foreach (var manufacturer in s.Manufacturers)
                Manufacturers.Add(new Manufacturer(manufacturer));
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public string Street { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public Guid ManufacturerFk { get; set; }

        [NotMapped]
        public List<Manufacturer> Manufacturers { get; set; }
    }
}
