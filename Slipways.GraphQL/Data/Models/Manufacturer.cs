using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Manufacturer : Entity
    {
        public Manufacturer()
        {
            Services = new HashSet<Manufacturer>();
        }
        public string Name { get; set; }

        [NotMapped]
        public ICollection<Manufacturer> Services { get; set; }
    }
}
