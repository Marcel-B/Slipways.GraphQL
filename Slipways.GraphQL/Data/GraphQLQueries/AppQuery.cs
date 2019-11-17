using com.b_velop.Slipways.GraphQL.Data.GraphQLTypes;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(
            SlipwaysContext db)
        {
            FieldAsync<ListGraphType<WaterType>>(
             "waters",
             resolve: async context => await db.Waters.ToListAsync());
        }
    }
}
