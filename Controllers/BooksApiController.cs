using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;

namespace MVCApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksApiController : ControllerBase
    {
        private static List<Books> books = new List<Books>
        {
            new Books("CleanCode", "Robert C.Martin",50.0),
            new Books("The Pragmatic Program","Andrew Hunt",36.50)
        };

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }
        [HttpGet("{id}")]
        public IActionResult GetBookbyId(int id)
        {
            return Ok(books[id]);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Books _book)
        {
            books.Add(_book);
            return CreatedAtAction(nameof(GetBooks), new { Id = books.Count - 1 }, _book);
        }

        [HttpPut]
        public IActionResult UpdateBook([FromBody] Books _book, int id)
        {
            return Ok(books[id]);
        }

        [HttpDelete("{id}")]
        
        public IActionResult DeleteBook(int id){
            books.RemoveAt(id);
            return NoContent();
        }
    }
}
