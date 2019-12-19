namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public abstract class Locationable : Entity
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
