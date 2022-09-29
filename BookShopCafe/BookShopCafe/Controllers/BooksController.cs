using BookShopCafe.Managers;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookShopCafe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //Bruger manager
        private IBookManager mgr = new BookManager();

        // GET: api/<BooksController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            List<Book> books = mgr.Get();
            if (books == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(books);
            }
        }

        // GET api/<BooksController>/5
        [HttpGet]
        [Route("{id}")]
        public Book Get(int id)
        {
            return mgr.GetById(id);
        }
        [HttpGet]
        [Route("Author/{author}")]
        public List<Book> GetAuthor(string author)
        {
            return mgr.GetByAuthor(author);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            return mgr.Create(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut]
        [Route("{id}")]
        public Book Put(int id, [FromBody] Book book)
        {
            return mgr.Update(id,book);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete]
        [Route("{id}")]
        public Book Delete(int id)
        {
            return mgr.Delete(id);
        }

        [HttpGet]
        [Route("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get([FromQuery] FilterPrice filter) {

            List<Book> liste = mgr.SearchPrice(filter.StartPrice, filter.EndPrice);
            return (liste.Count == 0) ? NoContent() : Ok(liste);
        }

    }
}
