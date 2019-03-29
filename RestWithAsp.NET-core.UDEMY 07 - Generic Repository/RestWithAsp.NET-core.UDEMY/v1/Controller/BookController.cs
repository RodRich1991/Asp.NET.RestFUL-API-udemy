using Microsoft.AspNetCore.Mvc;
using RestWithAsp.NET_core.UDEMY.V1.Model;
using RestWithAsp.NET_core.UDEMY.V1.Service;

namespace RestWithAsp.NET_core.UDEMY.V1.Controller
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET api/v1/book
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.FindAll());
        }

        // GET api/v1/book/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _bookService.FindById(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        // POST api/v1/book
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null)
                return BadRequest();
            return new ObjectResult(_bookService.Create(book));
        }

        // PUT api/v1/book/5
        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null)
                return BadRequest();
            return new ObjectResult(_bookService.Update(book));
        }

        // DELETE api/v1/book/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
