using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Slipways.GrQl.Controllers;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Slipway : Locationable, IEntity
    {
        public Slipway()
        {
            Extras = new List<Extra>();
        }

        public Slipway(
            SlipwayDto s)
        {
            Name = s.Name;
            WaterFk = s.WaterFk;
            Rating = s.Rating;
            Comment = s.Comment;
            Street = s.Street;
            Postalcode = s.Postalcode;
            City = s.City;
            Costs = s.Costs;
            Pro = s.Pro;
            Contra = s.Contra;
            Longitude = s.Longitude;
            Latitude = s.Latitude;
            Created = s.Created;
            Id = s.Id;
            Updated = s.Updated;
        }

        public string Name { get; set; }

        public Guid WaterFk { get; set; }

        [ForeignKey("WaterFk")]
        public Water Water { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public string Street { get; set; }

        public string Postalcode { get; set; }

        public string City { get; set; }

        public decimal Costs { get; set; }

        public string Pro { get; set; }

        public string Contra { get; set; }

        [NotMapped]
        public Guid ExtraFk { get; set; }

        [NotMapped]
        public List<Extra> Extras { get; set; }
    }
}
