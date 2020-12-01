using common.api.Entities;
using common.api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace common.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly DefaultDbContext _defaultDbContext;

        public RegionController(DefaultDbContext context)
        {
            _defaultDbContext = context;
        }

        [HttpGet]
        public IAsyncEnumerable<Region> GetAll() => _defaultDbContext.Regions.OrderBy(x => x.Name).AsAsyncEnumerable();

        [HttpGet("{id}")]
        public Region Get(int id) => _defaultDbContext.Regions.Find(id);

        [HttpGet("{id}/states")]
        public IAsyncEnumerable<State> GetByRegion(int id) => _defaultDbContext.States.Where(x => x.RegionId == id).OrderBy(x => x.Name).AsAsyncEnumerable();
    }
}
