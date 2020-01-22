using System;
using System.Collections.Generic;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Helper;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Models;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class AppDataType : ObjectGraphType<AppData>
    {
        public AppDataType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper repository)
        {
            Name = nameof(AppData);
            Description = "All values for mobile Applications";

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                Cache.Slipways,
                Cache.Slipways,
                resolve: async context => await repository.Slipway.SelectAllAsync());

            FieldAsync<ListGraphType<WaterType>, IEnumerable<Water>>(
                Cache.Waters,
                Cache.Waters,
                resolve: async context => await repository.Water.SelectAllAsync());

            FieldAsync<ListGraphType<StationType>, IEnumerable<Station>>(
              Cache.Stations,
              Cache.Stations,
              resolve: async context => await repository.Station.SelectAllAsync());

            FieldAsync<ListGraphType<PortType>, IEnumerable<Port>>(
              Cache.Ports,
              Cache.Ports,
              resolve: async context => await repository.Port.SelectAllAsync());

            FieldAsync<ListGraphType<ServiceType>, IEnumerable<Service>>(
              Cache.Services,
              Cache.Services,
              resolve: async context => await repository.Service.SelectAllAsync());
        }
    }
}
