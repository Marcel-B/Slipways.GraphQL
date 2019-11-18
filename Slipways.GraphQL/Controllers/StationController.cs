using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prometheus;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace com.b_velop.Slipways.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : Controller
    {
        private readonly IRepositoryWrapper _rep;
        private readonly ILogger<StationController> _logger;

        public StationController(
            IRepositoryWrapper rep,
            ILogger<StationController> logger)
        {
            _rep = rep;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Station>> GetAsync()
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_station_seconds", "Histogram").NewTimer())
            {
                var result = await _rep.Station.SelectStationsIncludeAllAsync();
                return result.OrderBy(_ => _.Longname);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Station>> GetAsync(
            Guid id)
        {
            using (Metrics.CreateHistogram($"slipwaysql_duration_GET_api_station_id_seconds", "Histogram").NewTimer())
            {
                return await _rep.Station.SelectByIdAsync(id);
            }
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
