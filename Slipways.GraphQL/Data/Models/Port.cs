using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Port : Locationable
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Street { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [ForeignKey("WaterFk")]
        public Water Water { get; set; }
        public Guid WaterFk { get; set; }
    }
}
