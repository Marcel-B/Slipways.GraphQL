using System;
using System.Collections.Generic;
using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Helper;
using com.b_velop.Slipways.Data.Models;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class ManufacturerType : ObjectGraphType<Manufacturer>
    {
        public ManufacturerType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper repository)
        {
            Name = nameof(Manufacturer);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Name);

            FieldAsync<ListGraphType<ServiceType>, IEnumerable<Service>>(
                Cache.Services,
                Cache.Services,
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Service>("GetServicesByManufacturerId", repository.Service.GetServicesByManufacturerIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
