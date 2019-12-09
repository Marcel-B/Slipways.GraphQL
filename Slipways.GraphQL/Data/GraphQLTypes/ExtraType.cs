using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using GraphQL.Types;
using System.Collections.Generic;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class ExtraType : ObjectGraphType<Extra>
    {
        public ExtraType(
            IRepositoryWrapper rep)
        {
            Name = "Extra";

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Name);

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                "Slipways",
                "Slipways",
                resolve: async ctx => await rep.Slipway.SelectByExtraIdAsync(ctx.Source.Id));
        }
    }
}
