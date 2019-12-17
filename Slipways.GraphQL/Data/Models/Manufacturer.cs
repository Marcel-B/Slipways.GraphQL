using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using com.b_velop.Slipways.GrQl.Data.Dtos;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Manufacturer : Entity
    {
        public Manufacturer()
        {
            Services = new HashSet<Manufacturer>();
        }

        public Manufacturer(
            ManufacturerDto m) : this()
        {
            Id = m.Id;
            Name = m.Name;
        }

        public string Name { get; set; }

        [NotMapped]
        public Guid ServiceFk { get; set; }

        [NotMapped]
        public ICollection<Manufacturer> Services { get; set; }
    }
}
