using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private Repository _repository;

        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _repository.Get();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Trip trip)
        {
            _repository.Add(trip);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Trip value)
        {
            _repository.Update(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
