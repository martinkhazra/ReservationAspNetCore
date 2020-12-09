using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationHallCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MrKhazraController : ControllerBase
    {
        [HttpGet("[action]/{a}/{b}")]
        public IActionResult Sum(int a, int b) => Ok(a + b);
    }
}
