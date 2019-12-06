using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Extra : Entity
    {
        public Extra()
        {
            Slipways = new List<Slipway>();
        }
        public string Name { get; set; }

        [NotMapped]
        public List<Slipway> Slipways { get; set; }
    }
}
