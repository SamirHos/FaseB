using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using WebAPIPrimopunto.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIPrimopunto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        // GET: api/<LogInController>
        [HttpGet]
        public async Task<ActionResult<string[]>> Get()
        {
            string auth = Request.Headers[HeaderNames.Authorization];
            if (!string.IsNullOrWhiteSpace(auth))
            {
                var token =  auth.Split(" ")[1];
                if (token == "") return new string[] { "value1", "value2" };
                else return Unauthorized();
            }
            return NotFound();

        }

        // GET api/<LogInController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LogInController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LogInController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogInController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
