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
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public Guid WaterFk { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Street { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public decimal Costs { get; set; }
        public string Pro { get; set; }
        public string Contra { get; set; }
        public IEnumerable<Guid> Extras { get; set; }
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
                try
                {
                    var slipway = new Slipway(slipwayDto);
                    slipway.Id = Guid.NewGuid();

                    var result = await _rep.Slipway.InsertAsync(slipway);
                    if (result != null)
                    {
                        var extras = new HashSet<SlipwayExtra>();
                        foreach (var extra in slipwayDto.Extras)
                        {
                            var slipwayExtra = new SlipwayExtra
                            {
                                Id = Guid.NewGuid(),
                                Created = DateTime.Now,
                                ExtraFk = extra,
                                SlipwayFk = result.Id,
                            };
                            extras.Add(slipwayExtra);
                        }
                        _ = await _rep.SlipwayExtra.InsertRangeAsync(extras);
                    }
                    return new JsonResult(result);
                }
                catch (Exception e)
                {
                    _logger.LogError(6666, $"Error occurred while insert Slipway", e);
                    return new StatusCodeResult(500);
                }
            }
        }

        [HttpDelete]
        [Authorize("allin")]
        public async Task<ActionResult> DeleteSlipwayAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_DELETE_api_slipway_seconds", "Histogram").NewTimer())
            {
                try
                {
                    var result = await _rep.Slipway.DeleteAsync(id);
                    return new JsonResult(result);
                }
                catch (Exception e)
                {
                    _logger.LogError(6666, $"Error occurred while deleting Slipway with id '{id}'", e);
                    return new StatusCodeResult(500);
                }
            }
        }
    }
}