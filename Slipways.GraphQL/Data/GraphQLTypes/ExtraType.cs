using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Models;
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
            IRepositoryWrapper rep)
        {
            Name =  nameof(Extra);

            Field(_ => _.Id, type: typeof(NonNullGraphType<IdGraphType>));
            Field(_ => _.Created);
            Field(_ => _.Updated, nullable: true);
            Field(_ => _.Name);

            FieldAsync<ListGraphType<SlipwayType>, IEnumerable<Slipway>>(
                "Slipways",
                "Slipways",
                resolve: async ctx =>
                {
                    var loader = accessor.Context.GetOrAddCollectionBatchLoader<Guid, Slipway>("GetSlipwaysByExtraIds", rep.Slipway.GetSlipwaysByExtraIdAsync);
                    return await loader.LoadAsync(ctx.Source.Id);
                });
        }
    }
}
