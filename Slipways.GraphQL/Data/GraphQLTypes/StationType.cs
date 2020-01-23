using System;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class StationType : ObjectGraphType<Station>
    {
        public StationType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper repository)
        {
            Name = nameof(Station);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>)).Description("Eindeutige unveränderliche ID.");
            Field(_ => _.Number).Description("Pegelnummer");
            Field(_ => _.Shortname).Description("Pegelname (max. 40 Zeichen)");
            Field(_ => _.Longname).Description("Pegelname (max. 255 Zeichen)");
            Field(_ => _.Km).Description("Flusskilometer");
            Field(_ => _.Agency).Description("Wasserstraßen- und Schifffahrtsamt");
            Field(_ => _.Longitude).Description("Längengrad in WGS84 Dezimalnotation");
            Field(_ => _.Latitude).Description("Breitengrad in WGS84 Dezimalnotation");
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);

            FieldAsync<WaterType, Water>(
                nameof(Station.Water),
                description: "The Water on which the measuring Station is located",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", repository.Water.GetWatersByIdAsync);
                    return await loader.LoadAsync(context.Source.WaterFk);
                });
        }
    }
}
