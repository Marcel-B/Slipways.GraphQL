using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.GrQl.Infrastructure;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLTypes
{
    public class ExtraType : ObjectGraphType<Extra>
    {
        public ExtraType(
            IDataLoaderContextAccessor accessor,
            IRepositoryWrapper repository)
        {
            Name = nameof(Extra);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Name);

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                TypeName.Slipways,
                "The Slipways which have this Extra",
                resolve: async context =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Slipway>("GetSlipwaysByExtraIds", repository.Slipway.GetSlipwaysByExtraIdAsync);
                    return await loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
