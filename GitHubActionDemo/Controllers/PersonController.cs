using Dapper;
using GitHubActionDemo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GitHubActionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {


        private readonly IDbConnection _db;


        public PersonController(IDbConnection db)
        {
            _db = db;
        }


        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sql = "select * from Person";
            var people = await _db.QueryAsync<PersonModel>(sql);
            return Ok(people);
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
