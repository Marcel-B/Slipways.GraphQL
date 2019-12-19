using System;
using System.ComponentModel.DataAnnotations.Schema;

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
