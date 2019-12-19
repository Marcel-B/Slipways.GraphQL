using com.b_velop.Slipways.GrQl.Data.GraphQLInputTypes;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using com.b_velop.Slipways.GrQl.Data.GraphQLTypes;
using GraphQL.Types;
using Microsoft.Extensions.Logging;
using Prometheus;
using System;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLQueries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(
            IRepositoryWrapper rep,
            ILogger<AppMutation> logger)
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
