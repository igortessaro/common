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

        [HttpGet("{id}")]
        public State Get(int id) => _defaultDbContext.States.Find(id);


        [HttpGet("{id}/cities")]
        public IAsyncEnumerable<City> GetByState(int id) => _defaultDbContext.Cities.Where(x => x.StateId == id).OrderBy(x => x.Name).AsAsyncEnumerable();
    }
}
