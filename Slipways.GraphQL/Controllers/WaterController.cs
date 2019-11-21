using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prometheus;

namespace Slipways.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterController : ControllerBase
    {
        private readonly IRepositoryWrapper _rep;
        private readonly ILogger<WaterController> _logger;

        public WaterController(
            IRepositoryWrapper rep,
            ILogger<WaterController> logger)
        {
            _rep = rep;
            _logger = logger;
        }

        // GET: api/water
        [HttpGet]
        public async Task<IEnumerable<Water>> GetAsync()
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_water_seconds", "Histogram").NewTimer())
            {
                var result = await _rep.Water.SelectAllAsync();
                return result.OrderBy(_ => _.Longname);
            }
        }

        // GET api/water/8177a148-5674-4b8f-8ded-050907f640f3
        [HttpGet("{id}")]
        public async Task<ActionResult<Water>> GetAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_water_id_seconds", "Histogram").NewTimer())
            {
                return await _rep.Water.SelectByIdAsync(id);
            }
        }
    }
}