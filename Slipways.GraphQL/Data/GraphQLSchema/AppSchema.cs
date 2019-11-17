using com.b_velop.Slipways.GraphQL.Data.GraphQLQueries;
using GraphQL;
using GraphQL.Types;

namespace com.b_velop.Slipways.GraphQL.Data.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(
            IDependencyResolver resolver)  : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
