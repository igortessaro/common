using common.api.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace common.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = new List<Gender>();
            result.Add(new Gender(1, "Male"));
            result.Add(new Gender(2, "Female"));
            result.Add(new Gender(3, "Other"));

            return Ok(result);
        }
    }
}
