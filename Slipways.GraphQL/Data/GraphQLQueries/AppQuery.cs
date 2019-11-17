using com.b_velop.Slipways.GraphQL.Data.GraphQLTypes;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using GraphQL.Types;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(
            IRepositoryWrapper rep)
        {
            FieldAsync<ListGraphType<WaterType>>(
             "waters",
             resolve: async ctx => await rep.Water.SelectAllAsync());

            FieldAsync<ListGraphType<StationType>>(
                "stations",
                resolve: async ctx => await rep.Station.SelectAllAsync());
        }
    }
}
