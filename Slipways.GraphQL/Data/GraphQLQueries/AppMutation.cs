using GraphQL.Types;
using Microsoft.Extensions.Logging;
using Prometheus;
using com.b_velop.Slipways.Data.Contracts;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLQueries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation()
        {
            using (Metrics.CreateHistogram("slipwaysql_duration_graphql_mutation_seconds", "").NewTimer())
            {
                Name = "Mutation";

                //FieldAsync<SlipwayType>(
                //    "createSlipway",
                //    "Creates a new Slipway",
                //    new QueryArguments(
                //        new QueryArgument<SlipwayInputType> { Name = "slipway" }),
                //    resolve: async ctx =>
                //    {
                //        var slipway = ctx.GetArgument<Slipway>("slipway");

                //        slipway.Id = Guid.NewGuid();

                //        return await rep.Slipway.InsertAsync(slipway);
                //    });
            }
        }
    }
}
