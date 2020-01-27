using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
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
            Field(_ => _.Name);
            Field(_ => _.Street);
            Field(_ => _.City);
            Field(_ => _.Postalcode);
            Field(_ => _.Costs);
            Field(_ => _.Rating);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Comment, nullable: true);
            Field(_ => _.Pro, nullable: true);
            Field(_ => _.Contra, nullable: true);
            Field(_ => _.Country, nullable: true);
            Field(_ => _.Latitude);
            Field(_ => _.Longitude);


            FieldAsync<WaterType, Water>(
                nameof(Station.Water),
                description: "The Water where the Slipway is located",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", repository.Water.GetWatersByIdAsync);
                    return await loader.LoadAsync(context.Source.WaterFk);
                });

            FieldAsync<PortType, Port>(
                nameof(Port),
                description: "A Port where the Slipway is located",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Port>("GetPortsById", repository.Port.GetPortsByIdAsync);
                    return await loader.LoadAsync(context.Source.PortFk ?? Guid.Empty);
                });

            FieldAsync<ListGraphType<ExtraType>, IEnumerable<Extra>>(
                TypeName.Extras,
                "Extras which the Slipway has to offer",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Extra>("GetExtrasBySlipwayId", repository.Extra.GetExtrasBySlipwayIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
