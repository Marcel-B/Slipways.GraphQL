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
             resolve: async context => await rep.Water.SelectAllAsync());
        }
    }
}
