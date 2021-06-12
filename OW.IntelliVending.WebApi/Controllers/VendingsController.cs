using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OW.IntelliVending.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendingsController : ControllerBase
    {
        // GET: api/<VendingsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "vending 1", "vending 2", "vending 3", "vending 4", "vending 5", "vending 6" };
        }

        // GET api/<VendingsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VendingsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VendingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
