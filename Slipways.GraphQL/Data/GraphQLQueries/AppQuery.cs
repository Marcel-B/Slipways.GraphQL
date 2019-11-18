using com.b_velop.Slipways.GraphQL.Data.GraphQLTypes;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using GraphQL.Types;
using Prometheus;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(
            IRepositoryWrapper rep)
        {
            using (Metrics.CreateHistogram("slipwaysql_duration_graphql_query_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<WaterType>>(
                 "waters",
                 resolve: async ctx => await rep.Water.SelectAllAsync());

                FieldAsync<ListGraphType<StationType>>(
                    "stations",
                    resolve: async ctx => await rep.Station.SelectAllAsync());

                FieldAsync<ListGraphType<SlipwayType>>(
                    "slipways",
                    resolve: async ctx => await rep.Slipway.SelectAllAsync());
            }
        }
    }
}
