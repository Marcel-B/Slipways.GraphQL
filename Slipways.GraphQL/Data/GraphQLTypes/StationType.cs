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
            IRepositoryWrapper rep)
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

            FieldAsync<WaterType, Water>(
                nameof(Station.Water),
                description: "Angaben zum Gewässer",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddBatchLoader<Guid, Water>("GetWatersById", rep.Water.GetWatersByIdAsync);
                    return await loader.LoadAsync(ctx.Source.WaterFk);
                });
        }
    }
}
