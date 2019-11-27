using com.b_velop.Slipways.GrQl.Data.Models;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class WaterType : ObjectGraphType<Water>
    {
        public WaterType()
        {
            Name = "Water";

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Shortname);
            Field(_ => _.Longname);
        }
    }
}
