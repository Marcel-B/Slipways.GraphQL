using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Manufacturer : Entity
    {
        public string Name { get; set; }
    }
}
