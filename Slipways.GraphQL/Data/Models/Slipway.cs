using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Slipway : Locationable, IEntity
    {
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
    }
}
