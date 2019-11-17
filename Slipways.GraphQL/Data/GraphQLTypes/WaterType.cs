using com.b_velop.Slipways.GraphQL.Data.Models;
using GraphQL.Types;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLTypes
{
    public class WaterType : ObjectGraphType<Water>
    {
        public WaterType()
        {
            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Shortname);
            Field(_ => _.Longname);
        }
    }
}
