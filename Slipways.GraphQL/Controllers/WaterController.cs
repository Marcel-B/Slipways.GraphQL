using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prometheus;

namespace Slipways.GrQl.Controllers
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
        [Authorize("reader")]
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
        [Authorize("reader")]
        public async Task<ActionResult<Water>> GetAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_water_id_seconds", "Histogram").NewTimer())
            {
                return await _rep.Water.SelectByIdAsync(id);
            }
        }

        [HttpPost]
        [Authorize("allin")]
        public async Task<ActionResult> PostAsync(
            com.b_velop.Slipways.GrQl.Data.Dtos.Water waterDto)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_POST_api_water_seconds", "Histogram").NewTimer())
            {
                var water = new Water
                {
                    Id = Guid.NewGuid(),
                    Longname = waterDto.Longname.ToUpper(),
                    Shortname = waterDto.Shortname.ToUpper(),
                    Created = DateTime.Now
                };
                var result = await _rep.Water.InsertAsync(water);
                return Ok();
            }
        }
    }
}