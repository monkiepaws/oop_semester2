using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Contact")]
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("YAHOOO! Sent back from Contact controller (get)");
        }
        [HttpPost]
        public IActionResult Post(string name, string email, string message)
        {
            return Ok("Sent back from the Contact controller!! (post)");
        }
    }
}