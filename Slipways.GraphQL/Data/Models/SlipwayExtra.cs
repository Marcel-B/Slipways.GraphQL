using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class SlipwayExtra : Entity
    {
        public Guid SlipwayFk { get; set; }

        public Guid ExtraFk { get; set; }

        [ForeignKey("SlipwayFk")]
        public Slipway Slipway { get; set; }

        [ForeignKey("ExtraFk")]
        public Extra Extra { get; set; }
    }
}
