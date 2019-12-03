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
    public class SlipwayDto
    {
        public string Name { get; set; }
        public string City { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Guid Water { get; set; }
    }

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
        [Authorize("reader")]
        public async Task<IEnumerable<Slipway>> GetAsync()
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_slipway_seconds", "Histogram").NewTimer())
            {
                var result = await _rep.Slipway.SelectIncludeAllAsync();
                return result.OrderBy(_ => _.Name);
            }
        }

        // GET api/slipway/8177a148-5674-4b8f-8ded-050907f640f3
        [HttpGet("{id}")]
        [Authorize("reader")]
        public async Task<ActionResult<Slipway>> GetAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_slipway_id_seconds", "Histogram").NewTimer())
            {
                return await _rep.Slipway.SelectByIdIncludeAsync(id);
            }
        }

        [HttpPost]
        [Authorize("allin")]
        public async Task<ActionResult> PostAsync(
            SlipwayDto slipwayDto)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_POST_api_slipway_seconds", "Histogram").NewTimer())
            {
                var slipway = new Slipway
                {
                    Id = Guid.NewGuid(),
                    City = slipwayDto.City,
                    Name = slipwayDto.Name,
                    Longitude = slipwayDto.Longitude,
                    Latitude = slipwayDto.Latitude,
                    WaterFk = slipwayDto.Water
                };
                var result = await _rep.Slipway.InsertAsync(slipway);
                return Ok();
            }
        }
    }
}