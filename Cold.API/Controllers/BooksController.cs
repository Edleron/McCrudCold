using Cold.Business.Abstract;
using Cold.Business.Concrete;
using Cold.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cold.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public List<Book> Get()
        {
            return _bookService.GetAllBooks();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookService.GetBookById(id);
        }

        [HttpPost]
        public Book Post([FromBody] Book book) 
        { 
            return _bookService.CreateBook(book);
        }

        [HttpPut]
        public Book Put([FromBody] Book book)
        {
            return _bookService.UpdateBook(book);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookService.DeleteBook(id);
        }
    }
}
