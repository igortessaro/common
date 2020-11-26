using common.api.Entities;
using common.api.Repository;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAll()
        {
            return Ok(_defaultDbContext.States.ToList());
        }

        [HttpGet("region/{regionId}")]
        public IActionResult GetByRegion(int regionId)
        {
            return Ok(_defaultDbContext.States.Where(x => x.RegionId == regionId).ToList());
        }

        [HttpGet("{id}")]
        public State Get(int id)
        {
            return _defaultDbContext.States.Find(id);
        }
    }
}
