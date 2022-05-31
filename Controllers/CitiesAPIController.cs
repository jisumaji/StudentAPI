using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_day_23_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesAPIController : ControllerBase
    {

        List<string> cities = InitCities();


        public static List<string> InitCities()
        {
            List<string> cts = new List<string>() { "Hyderabad", "Chennai", "Bengaluru", "Kolkatta", "Pune" };
            return cts;
        }

        // GET: api/<CitiesAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return cities;
        }

        // GET api/<CitiesAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return cities[id];
        }

        // POST api/<CitiesAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            cities.Add(value);
        }

        // PUT api/<CitiesAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            cities[id] = value;
        }

        // DELETE api/<CitiesAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            cities.RemoveAt(id);
        }
    }
}
