using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("updated")]
        public DateTime? Updated { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("waterFk")]
        public Guid WaterFk { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("postalcode")]
        public string Postalcode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("costs")]
        public decimal Costs { get; set; }

        [JsonPropertyName("pro")]
        public string Pro { get; set; }

        [JsonPropertyName("contra")]
        public string Contra { get; set; }

        [JsonPropertyName("extras")]
        public IEnumerable<Guid> Extras { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class SlipwayController : ControllerBase
    {
        private readonly JsonSerializerOptions _options;
        private readonly IRepositoryWrapper _rep;
        private readonly ILogger<SlipwayController> _logger;

        public SlipwayController(
            IRepositoryWrapper rep,
            ILogger<SlipwayController> logger)
        {
            _options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                IgnoreNullValues = true
            };
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
                    slipwayDto.Id = slipway.Id;
                    slipwayDto.Created = result.Created;
                    return new JsonResult(slipway, _options);
                }
                catch (Exception e)
                {
                    _logger.LogError(6666, $"Error occurred while insert Slipway", e);
                    return new StatusCodeResult(500);
                }
            }
        }

        [HttpDelete("{id}")]
        [Authorize("allin")]
        public async Task<ActionResult> DeleteSlipwayAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_DELETE_api_slipway_seconds", "Histogram").NewTimer())
            {
                try
                {
                    var result = await _rep.Slipway.DeleteAsync(id);
                    return new JsonResult(result, _options);
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