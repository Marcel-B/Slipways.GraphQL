using System;
using com.b_velop.Slipways.GrQl.Data.GraphQLTypes;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using GraphQL.Types;
using Prometheus;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(
            IRepositoryWrapper rep)
        {
            using (Metrics.CreateHistogram("slipwaysql_duration_graphql_query_seconds", "").NewTimer())
            {
                FieldAsync<ListGraphType<WaterType>>(
                 "waters",
                 resolve: async ctx => await rep.Water.SelectAllAsync());

                FieldAsync<ListGraphType<StationType>>(
                    "stations",
                    resolve: async ctx => await rep.Station.SelectAllAsync());

                FieldAsync<ListGraphType<SlipwayType>>(
                    "slipways",
                    resolve: async ctx => await rep.Slipway.SelectAllAsync());

                FieldAsync<ListGraphType<ExtraType>>(
                    "extras",
                    resolve: async ctx => await rep.Extra.SelectAllAsync());

                FieldAsync<ListGraphType<PortType>>(
                   "ports",
                   resolve: async ctx => await rep.Port.SelectAllAsync());

                FieldAsync<ListGraphType<ServiceType>>(
                    "services",
                    resolve: async ctx => await rep.Service.SelectAllAsync());

                FieldAsync<ListGraphType<ManufacturerType>>(
                    "manufacturers",
                    resolve: async ctx => await rep.Manufacturer.SelectAllAsync());


                FieldAsync<SlipwayType>(
                    nameof(Slipway),
                    "Select Slipway by ID",
                    new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = nameof(Slipway.Id), Description = "The unique identifier of the unit" }),
                    resolve: async ctx =>
                    {
                        var id = ctx.GetArgument<Guid>(nameof(Slipway.Id));
                        var slipway = await rep.Slipway.SelectByIdAsync(id);
                        return slipway;
                    });
            }
        }
    }
}
