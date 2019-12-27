using System;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class PortType : ObjectGraphType<Port>
    {
        public PortType(
            IRepositoryWrapper rep,
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
                "",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", rep.Water.GetWatersByIdAsync);
                    return await loader.LoadAsync(ctx.Source.WaterFk);
                });
        }
    }
}
