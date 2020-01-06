using System;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Data.GraphQLTypes;
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
                 "waters",
                 resolve: async context => await repositories.Water.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_stations_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<StationType>>(
                    "stations",
                    resolve: async context => await repositories.Station.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_slipways_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<SlipwayType>>(
                    "slipways",
                    resolve: async context => await repositories.Slipway.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<ExtraType>>(
                    "extras",
                    resolve: async context => await repositories.Extra.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_ports_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<PortType>>(
                   "ports",
                   resolve: async context => await repositories.Port.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_services_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<ServiceType>>(
                    "services",
                    resolve: async context => await repositories.Service.SelectAllAsync());
            }

            using (Metrics.CreateHistogram("slipways_gql_duration_graphql_query_manufacturers_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<ManufacturerType>>(
                    "manufacturers",
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
        }
    }
}
