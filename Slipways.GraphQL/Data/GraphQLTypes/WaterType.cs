using System;
using System.Collections.Generic;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Helper;
using com.b_velop.Slipways.Data.Models;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class WaterType : ObjectGraphType<Water>
    {
        public WaterType(
            IRepositoryWrapper repository,
            IDataLoaderContextAccessor accessor)
        {
            Name = nameof(Water);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Shortname);
            Field(_ => _.Longname);

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                Cache.Slipways,
                Cache.Slipways,
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Slipway>("GetSlipwaysByWaterId", repository.Slipway.GetSlipwayByWaterIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });

            FieldAsync<ListGraphType<StationType>, IEnumerable<Station>>(
                Cache.Stations,
                Cache.Stations,
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Station>("GetStationsByWaterId", repository.Station.GetStationsByWaterIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });

            FieldAsync<ListGraphType<PortType>, IEnumerable<Port>>(
                "Ports",
                "Ports",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Port>("GetPortsByWaterId", repository.Port.GetPortsByWaterIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
