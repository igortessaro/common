using common.api.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace common.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassificationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = new List<Classification>();

            result.Add(new Classification(1, "Gold"));
            result.Add(new Classification(2, "Silver"));
            result.Add(new Classification(3, "Bronze"));

            return Ok(result);
        }
    }
}
