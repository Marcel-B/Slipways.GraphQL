using System;
using System.Collections.Generic;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
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
            Field(_ => _.Updated, nullable: true);

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                TypeName.Slipways,
                "All Slipways that are located on these Waters",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Slipway>("GetSlipwaysByWaterId", repository.Slipway.GetSlipwayByWaterIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });

            FieldAsync<ListGraphType<StationType>, IEnumerable<Station>>(
                TypeName.Stations,
                "All Stations that are located on these Waters",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Station>("GetStationsByWaterId", repository.Station.GetStationsByWaterIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });

            FieldAsync<ListGraphType<PortType>, IEnumerable<Port>>(
                TypeName.Ports,
                "All Ports that are located on these Waters",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Port>("GetPortsByWaterId", repository.Port.GetPortsByWaterIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
