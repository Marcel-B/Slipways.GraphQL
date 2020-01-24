using System.Collections.Generic;
using com.b_velop.Slipways.Data.Models;

namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class AppData
    {
        public IEnumerable<Slipway> Slipways { get; set; }
        public IEnumerable<Port> Ports { get; set; }
        public IEnumerable<Water> Waters { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Station> Stations { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
        public IEnumerable<Extra> Extras { get; set; }
    }
}
