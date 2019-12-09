using System;
using System.Collections.Generic;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class WaterType : ObjectGraphType<Water>
    {
        public WaterType(
            IRepositoryWrapper rep,
            IDataLoaderContextAccessor accessor)
        {
            Name = nameof(Water);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Shortname);
            Field(_ => _.Longname);

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                "Slipways",
                "Slipways",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Slipway>("GetSlipwaysByWaterId", rep.Slipway.GetSlipwayByWaterIdAsync);
                    return await loader.LoadAsync(ctx.Source.Id);
                });

            FieldAsync<ListGraphType<StationType>, IEnumerable<Station>>(
                "Stations",
                "Stations",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Station>("GetStationsByWaterId", rep.Station.GetStationsByWaterIdAsync);
                    return await loader.LoadAsync(ctx.Source.Id);
                });
        }
    }
}
