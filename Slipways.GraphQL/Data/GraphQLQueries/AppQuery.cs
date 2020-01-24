using System;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Data.GraphQLTypes;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using GraphQL.Types;
using Prometheus;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(
            IRepositoryWrapper repositories)
        {
            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_waters_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<WaterType>>(
                    name: TypeName.Waters,
                    description: "Provides all Waters",
                    resolve: async context => await repositories.Water.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_stations_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<StationType>>(
                    name: TypeName.Stations,
                    description: "Provides all Stations",
                    resolve: async context => await repositories.Station.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_slipways_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<SlipwayType>>(
                    name: TypeName.Slipways,
                    description: "Provides all Slipways",
                    resolve: async context => await repositories.Slipway.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<ExtraType>>(
                    name: TypeName.Extras,
                    description: "Provides all Extras",
                    resolve: async context => await repositories.Extra.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_ports_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<PortType>>(
                   name: TypeName.Ports,
                   description: "Provides all Ports",
                   resolve: async context => await repositories.Port.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_services_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<ServiceType>>(
                    name: TypeName.Services,
                    description: "Provides all Services",
                    resolve: async context => await repositories.Service.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_manufacturers_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<ManufacturerType>>(
                    name: TypeName.Manufacturers,
                    description: "Provides all Manufacturers",
                    resolve: async context => await repositories.Manufacturer.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_slipway_seconds", "").NewTimer())
            {
                FieldAsync<SlipwayType>(
                    nameof(Slipway),
                    "Select Slipway by ID",
                    new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = nameof(Slipway.Id), Description = "The unique identifier of the unit" }),
                    resolve: async context =>
                    {
                        var id = context.GetArgument<Guid>(nameof(Slipway.Id));
                        var slipway = await repositories.Slipway.SelectByIdAsync(id);
                        return slipway;
                    });
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_appdata_seconds", "").NewTimer())
            {
                FieldAsync<AppDataType>(
                    nameof(AppData),
                    "Select Application Data",
                    resolve: async context =>
                    {
                        var appData = new AppData
                        {
                            Slipways = await repositories.Slipway.SelectAllAsync(),
                            Waters = await repositories.Water.SelectAllAsync(),
                            Stations = await repositories.Station.SelectAllAsync(),
                            Services = await repositories.Service.SelectAllAsync(),
                            Extras = await repositories.Extra.SelectAllAsync(),
                            Manufacturers = await repositories.Manufacturer.SelectAllAsync(),
                            Ports = await repositories.Port.SelectAllAsync()
                        };
                        return appData;
                    });
            }
        }
    }
}
