using System;
using System.Collections.Generic;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class ManufacturerType : ObjectGraphType<Manufacturer>
    {
        public ManufacturerType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper rep)
        {
            Name = nameof(Manufacturer);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Name);

            FieldAsync<ListGraphType<ServiceType>, IEnumerable<Service>>(
                "Services",
                "",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Service>("GetServicesByManufacturerId", rep.Service.GetServicesByManufacturerIdAsync);
                    return await loader.LoadAsync(ctx.Source.Id);
                });
        }
    }
}
