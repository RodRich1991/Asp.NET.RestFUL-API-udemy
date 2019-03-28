using Microsoft.AspNetCore.Mvc;
using RestWithAsp.NET_core.UDEMY.Services;

namespace RestWithAsp.NET_core.UDEMY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {

        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/person
        [HttpGet]
        public IActionResult Get()
        {   
            return Ok(_personService.FindAll());
        }

        // GET api/person/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null)
                return NotFound();
            return Ok(_personService.FindById(id));
        }

        // POST api/person
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personService.Create(person));
        }

        // PUT api/person/5
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personService.Update(person));
        }

        // DELETE api/person/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
