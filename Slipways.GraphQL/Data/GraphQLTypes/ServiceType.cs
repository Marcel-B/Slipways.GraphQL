using System;
using System.Collections.Generic;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class ServiceType : ObjectGraphType<Service>
    {
        public ServiceType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper rep)
        {
            Name = nameof(Service);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Name);
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Street);
            Field(_ => _.Postalcode);
            Field(_ => _.City);
            Field(_ => _.Phone, nullable: true);
            Field(_ => _.Url, nullable: true);
            Field(_ => _.Latitude);
            Field(_ => _.Longitude);

            FieldAsync<ListGraphType<ManufacturerType>, IEnumerable<Manufacturer>>(
                "Manufacturers",
                "",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Manufacturer>("GetManufacturerByServiceId", rep.Manufacturer.GetManufacturerByServiceIdAsync);
                    return await loader.LoadAsync(ctx.Source.Id);
                });
        }
    }
}
