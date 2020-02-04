using com.b_velop.Slipways.GrQl.Data.GraphQLQueries;
using GraphQL;
using GraphQL.Types;

namespace com.b_velop.Slipways.GrQl.Data.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(
            IDependencyResolver resolver)  : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
            Subscription = resolver.Resolve<AppQuery>();
            //Mutation = resolver.Resolve<AppMutation>();
        }
    }
}
