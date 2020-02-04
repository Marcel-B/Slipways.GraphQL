using com.b_velop.Slipways.Data.Contracts;
using com.b_velop.Slipways.Data.Helper;
using com.b_velop.Slipways.Data.Models;
using com.b_velop.Slipways.Data.Repositories;
using com.b_velop.Slipways.GrQl.Data.GraphQLTypes;
using GraphQL.Resolvers;
using GraphQL.Subscription;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLQueries
{



    public class AppSubscription : ObjectGraphType
    {
        IRepositoryWrapper wrapper;

        public AppSubscription(
            IRepositoryWrapper repository)
        {
            wrapper = repository;

            AddField(new EventStreamFieldType
            {
                Name = "valueAdded",
                Type = typeof(ExtraType),
                Resolver = new FuncFieldResolver<Extra>(ResolveExtra),
                Subscriber = new EventStreamResolver<Extra>(Subscribe)
            });
        }

        private Extra ResolveExtra(
            ResolveFieldContext context)
        {
            var extra = context.Source as Extra;
            return extra;
        }

        private IObservable<Extra> Subscribe(
            ResolveEventStreamContext context)
        {
            return wrapper.Extra;
        }

        private async Task<IObservable<Extra>> SubscribeAsync(
            ResolveEventStreamContext context)
        {
            return wrapper.Extra;
        }
    }
}
