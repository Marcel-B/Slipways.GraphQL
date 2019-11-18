using com.b_velop.Slipways.GraphQL.Data.GraphQLInputTypes;
using com.b_velop.Slipways.GraphQL.Data.GraphQLTypes;
using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using GraphQL.Types;
using Microsoft.Extensions.Logging;
using System;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLQueries
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(
            IRepositoryWrapper rep,
            ILogger<AppMutation> logger)
        {
            Name = "Mutation";

            FieldAsync<SlipwayType>(
                "createSlipway",
                "Creates a new Slipway",
                new QueryArguments(
                    new QueryArgument<SlipwayInputType> { Name = "slipway" }),
                resolve: async ctx =>
                {
                    var slipway = ctx.GetArgument<Slipway>("slipway");

                    slipway.Id = Guid.NewGuid();

                    return await rep.Slipway.InsertAsync(slipway);
                });
        }
    }
}
