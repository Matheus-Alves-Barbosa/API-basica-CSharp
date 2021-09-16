using AulaUdemy.Model;
using AulaUdemy.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AulaUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;

        private IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var bookVO = _bookService.FindByID(id);
            if (bookVO == null)
                return NotFound();
            return Ok(bookVO);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookVO bookVO)
        {
            if (bookVO == null)
                return BadRequest();
            return Ok(_bookService.Create(bookVO));
        }

        [HttpPut]
        public IActionResult Put([FromBody] BookVO bookVO)
        {
            if (bookVO == null)
                return BadRequest();
            return Ok(_bookService.Update(bookVO));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
