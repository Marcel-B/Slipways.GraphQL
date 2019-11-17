using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace com.b_velop.Slipways.GraphQL.Data.Models
{
    public class Water
    {
        [Key]
        public Guid Id { get; set; }
        public string Shortname { get; set; }
        public string Longname { get; set; }

        //public IEnumerable<Station> Stations { get; set; }
        //public IEnumerable<Slipway> Slipways { get; set; }
    }
}
