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
    public class StateController : ControllerBase
    {
        private readonly DefaultDbContext _defaultDbContext;

        public StateController(DefaultDbContext context)
        {
            _defaultDbContext = context;
        }

        [HttpGet]
        public IAsyncEnumerable<State> GetAll() => _defaultDbContext.States.OrderBy(x => x.Name).AsAsyncEnumerable();

        [HttpGet("region/{regionId}")]
        public IAsyncEnumerable<State> GetByRegion(int regionId) => _defaultDbContext.States.Where(x => x.RegionId == regionId).OrderBy(x => x.Name).AsAsyncEnumerable();

        [HttpGet("{id}")]
        public State Get(int id) => _defaultDbContext.States.Find(id);
    }
}
