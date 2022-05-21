using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TRAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        public Context Context { get; set; }
        public StationsController(Context context)
        {
            Context = context;
        }

        // GET: api/<StationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("stations")]
        public IEnumerable<RequestClass> Get(string fuel)
        {
            var a =  Context.Stations.Include(x => x.Data).Where(station => station.Data.Any(data => data.Name == fuel)).Select(station => (JsonConvert.DeserializeObject<RequestClass>(JsonConvert.SerializeObject(station))).GetPrice(fuel)).ToList();
            return a;
        }

        // POST api/<StationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
