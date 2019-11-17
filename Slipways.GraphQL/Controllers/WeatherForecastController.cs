using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data;
using com.b_velop.Slipways.GraphQL.Data.Models;
using com.b_velop.Slipways.GraphQL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWsvService _service;
        private readonly SlipwaysContext _context;

        public WeatherForecastController(
            IWsvService service,
            SlipwaysContext context,
            ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _service = service;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Water>> GetAsync()
        {
            var result = await _service.GetAsync();
            _logger.LogInformation(result.Longname);
            var water = _context.Waters.ToList();
            return water;
        }
    }
}
