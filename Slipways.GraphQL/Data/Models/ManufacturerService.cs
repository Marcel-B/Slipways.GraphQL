using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class ManufacturerService : Entity
    {
        [ForeignKey("ManufacturerFk")]
        public Manufacturer Manufacturer { get; set; }

        [ForeignKey("ServiceFk")]
        public Service Service { get; set; }

        public Guid ServiceFk { get; set; }

        public Guid ManufacturerFk { get; set; }

    }
}
