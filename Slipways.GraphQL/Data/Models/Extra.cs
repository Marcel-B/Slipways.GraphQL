using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Extra : Entity
    {
        public Extra()
        {
            Slipways = new HashSet<Slipway>();
        }
        public string Name { get; set; }

        [NotMapped]
        public ICollection<Slipway> Slipways { get; set; }
    }
}
