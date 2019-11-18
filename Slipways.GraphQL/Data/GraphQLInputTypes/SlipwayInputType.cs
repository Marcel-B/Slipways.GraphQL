using com.b_velop.Slipways.GraphQL.Data.Models;
using GraphQL.Types;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLInputTypes
{
    public class SlipwayInputType : InputObjectGraphType<Slipway>
    {
        public SlipwayInputType()
        {
            Name = "SlipwayInput";

            Field(_ => _.Name);
            Field(_ => _.Latitude);
            Field(_ => _.Longitude);
            Field(_ => _.Rating);
            Field(_ => _.Costs);
            Field(_ => _.WaterFk, type: typeof(NonNullGraphType<IdGraphType>));

            Field(_ => _.City, nullable: true);
            Field(_ => _.Postalcode, nullable: true);
            Field(_ => _.Pro, nullable: true);
            Field(_ => _.Contra, nullable: true);
            Field(_ => _.Comment, nullable: true);
        }
    }
}
