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
    public class CityController : ControllerBase
    {
        private readonly DefaultDbContext _defaultDbContext;

        public CityController(DefaultDbContext context)
        {
            _defaultDbContext = context;
        }

        [HttpGet]
        public IAsyncEnumerable<City> GetAll() => _defaultDbContext.Cities.OrderBy(x => x.Name).AsAsyncEnumerable();

        [HttpGet("state/{stateId}")]
        public IAsyncEnumerable<City> GetByState(int stateId) => _defaultDbContext.Cities.Where(x => x.StateId == stateId).OrderBy(x => x.Name).AsAsyncEnumerable();

        [HttpGet("{id}")]
        public City Get(int id) => _defaultDbContext.Cities.Find(id);
    }
}
