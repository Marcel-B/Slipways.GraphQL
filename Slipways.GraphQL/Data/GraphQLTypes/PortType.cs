using System;
using System.Collections.Generic;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class PortType : ObjectGraphType<Port>
    {
        public PortType(
            IRepositoryWrapper repository,
            IDataLoaderContextAccessor accessor)
        {
            Name = nameof(Port);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));

            Field(_ => _.Name);
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Longitude);
            Field(_ => _.Latitude);
            Field(_ => _.Email, nullable: true);
            Field(_ => _.Phone, nullable: true);
            Field(_ => _.Street);
            Field(_ => _.Postalcode);
            Field(_ => _.City);
            Field(_ => _.Url, nullable: true);

            FieldAsync<WaterType, Water>(
                nameof(Water),
                "The Water on which the Port is located",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", repository.Water.GetWatersByIdAsync);
                    return await loader.LoadAsync(context.Source.WaterFk);
                });

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                TypeName.Slipways,
                "Slipways located at this port",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Slipway>("GetSlipwaysByPortIds", repository.Slipway.GetSlipwaysByPortIdAsync);
                    return await loader.LoadAsync(context.Source.WaterFk);
                });
        }
    }
}
