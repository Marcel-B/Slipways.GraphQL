using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using com.b_velop.Slipways.GrQl.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace com.b_velop.Slipways.GrQl.Controllers
{
    [Route("api/[controller]")]
    public class ServiceController : Controller
    {
        private IRepositoryWrapper _rep;

        public ServiceController(
            IRepositoryWrapper rep)
        {
            _rep = rep;
        }

        // GET: api/values
        [HttpGet]
        [Authorize("reader")]
        public async Task<IEnumerable<Service>> Get()
        {
            var values = await _rep.Service.GetAllIncludeAsync();
            return values;
        }
    }
}
