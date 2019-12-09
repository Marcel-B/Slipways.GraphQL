using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class SlipwayType : ObjectGraphType<Slipway>
    {
        public SlipwayType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper rep)
        {
            Name = "Slipway";
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
                    // Get or add a batch loader with the key "GetUsersById"
                    // The loader will call GetUsersByIdAsync for each batch of keys
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", rep.Water.GetWatersByIdAsync);
                    // Add this UserId to the pending keys to fetch
                    // The task will complete once the GetUsersByIdAsync() returns with the batched results
                    return await loader.LoadAsync(ctx.Source.Id);
                });
        }
    }
}
