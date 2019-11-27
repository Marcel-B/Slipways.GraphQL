using com.b_velop.Slipways.GrQl.Data.GraphQLSchema;
using GraphQL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Slipways.GrQl.Controllers
{
    public class GraphQLQuery
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public dynamic Variables { get; set; }
    }

    public class GraphQLQuery2
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }

    [Route("graphql")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private AppSchema _schema;

        public GraphQLController(
            AppSchema schema)
        {
            _schema = schema;
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            GraphQLQuery query)
        {
            var query2 = new GraphQLQuery2
            {
                NamedQuery = query.NamedQuery,
                OperationName = query.OperationName,
                Query = query.Query,
                Variables = JObject.Parse(query.Variables.ToString())
            };
            var inputs = query2.Variables.ToInputs();
            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = _schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}