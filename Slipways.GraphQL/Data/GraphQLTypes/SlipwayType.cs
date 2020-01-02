using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Helper;
using com.b_velop.Slipways.Data.Models;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class SlipwayType : ObjectGraphType<Slipway>
    {
        public SlipwayType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper repository)
        {
            Name = nameof(Slipway);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
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
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", repository.Water.GetWatersByIdAsync);
                    return await loader.LoadAsync(ctx.Source.WaterFk);
                });

            FieldAsync<ListGraphType<ExtraType>, IEnumerable<Extra>>(
                Cache.Extras,
                Cache.Extras,
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Extra>("GetExtrasBySlipwayId", repository.Extra.GetExtrasBySlipwayIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
