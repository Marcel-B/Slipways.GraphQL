namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public class Service : Locationable
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Street { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
