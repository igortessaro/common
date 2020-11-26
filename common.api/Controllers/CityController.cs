using common.api.Entities;
using common.api.Repository;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAll()
        {
            return Ok(_defaultDbContext.Cities.ToList());
        }

        [HttpGet("state/{stateId}")]
        public IActionResult GetByState(int stateId)
        {
            var result = _defaultDbContext.Cities.Where(x => x.StateId == stateId).ToList();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public City Get(int id)
        {
            return _defaultDbContext.Cities.Find(id);
        }
    }
}
