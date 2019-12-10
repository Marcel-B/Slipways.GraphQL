using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Service : Locationable
    {
        public Service()
        {
            Manufacturers = new List<Manufacturer>();
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
