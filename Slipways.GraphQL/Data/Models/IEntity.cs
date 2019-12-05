using System;
namespace com.b_velop.Slipways.GrQl.Data.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
