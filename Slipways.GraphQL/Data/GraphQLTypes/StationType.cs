using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using GraphQL.Types;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLTypes
{
    public class StationType : ObjectGraphType<Station>
    {
        public StationType(
            IRepositoryWrapper rep)
        {
            Name = "Station";

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
                resolve: async ctx => await rep.Water.SelectByIdAsync(ctx.Source.WaterFk));
        }
    }
}
