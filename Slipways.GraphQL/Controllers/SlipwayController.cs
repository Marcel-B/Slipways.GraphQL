using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prometheus;

namespace Slipways.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlipwayController : ControllerBase
    {
        private readonly IRepositoryWrapper _rep;
        private readonly ILogger<SlipwayController> _logger;

        public SlipwayController(
            IRepositoryWrapper rep,
            ILogger<SlipwayController> logger)
        {
            _rep = rep;
            _logger = logger;
        }

        // GET: api/slipway
        [HttpGet]
        public async Task<IEnumerable<Slipway>> GetAsync()
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_slipway_seconds", "Histogram").NewTimer())
            {
                var result = await _rep.Slipway.SelectIncludeAllAsync();
                return result.OrderBy(_ => _.Name);
            }
        }

        // GET api/slipway/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Slipway>> GetAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_slipway_id_seconds", "Histogram").NewTimer())
            {
                return await _rep.Slipway.SelectIncludeAsync(id);
            }
        }
    }
}