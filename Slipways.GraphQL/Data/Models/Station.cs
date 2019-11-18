using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GraphQL.Data.Models
{
    public class Station : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Shortname { get; set; }
        public string Longname { get; set; }
        public double Km { get; set; }
        public string Agency { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Guid WaterFk { get; set; }

        [ForeignKey("WaterFk")]
        public Water Water { get; set; }
    }
}
