using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GraphQL.Data.Models
{
    public class Slipway
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public Guid WaterFk { get; set; }

        [ForeignKey("WaterFk")]
        public Water Water { get; set; }

        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public decimal Costs { get; set; }
        public string Pro { get; set; }
        public string Contra { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
