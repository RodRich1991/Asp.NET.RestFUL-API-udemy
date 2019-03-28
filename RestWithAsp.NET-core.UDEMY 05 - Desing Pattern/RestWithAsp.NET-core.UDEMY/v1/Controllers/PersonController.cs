using Microsoft.AspNetCore.Mvc;
using RestWithAsp.NET_core.UDEMY.V1.Models;
using RestWithAsp.NET_core.UDEMY.V1.Services;

namespace RestWithAsp.NET_core.UDEMY.V1.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {

        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/v1/person
        [HttpGet]
        public IActionResult Get()
        {   
            return Ok(_personService.FindAll());
        }

        // GET api/v1/person/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null)
                return NotFound();
            return Ok(_personService.FindById(id));
        }

        // POST api/v1/person
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personService.Create(person));
        }

        // PUT api/v1/person/5
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personService.Update(person));
        }

        // DELETE api/v1/person/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
