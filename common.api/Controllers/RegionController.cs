using common.api.Entities;
using common.api.Repository;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAll()
        {
            return Ok(_defaultDbContext.Regions.ToList());
        }

        [HttpGet("{id}")]
        public Region Get(int id)
        {
            return _defaultDbContext.Regions.Find(id);
        }
    }
}
