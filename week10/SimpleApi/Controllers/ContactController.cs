using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using SimpleApi.Models;

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
        public IActionResult Post([FromBody] PostDataModel data)
        {
            return Ok(Json(data));
        }
    }
}