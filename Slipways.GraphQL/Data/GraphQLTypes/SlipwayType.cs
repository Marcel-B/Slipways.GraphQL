using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using GraphQL.Authorization;
using GraphQL.Types;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLTypes
{
    public class SlipwayType : ObjectGraphType<Slipway>
    {
        public SlipwayType(
            IRepositoryWrapper rep)
        {
            Name = "Slipway";
            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Name);
            Field(_ => _.Street);
            Field(_ => _.City);
            Field(_ => _.Postalcode);
            Field(_ => _.Costs);
            Field(_ => _.Comment);
            Field(_ => _.Rating);
            Field(_ => _.Pro);
            Field(_ => _.Contra);
            Field(_ => _.Latitude);
            Field(_ => _.Longitude);

            FieldAsync<WaterType, Water>(
                nameof(Station.Water),
                description: "Angaben zum Gewässer",
                resolve: async ctx => await rep.Water.SelectByIdAsync(ctx.Source.WaterFk));
        }
    }
}
