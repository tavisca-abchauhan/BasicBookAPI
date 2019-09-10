using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicWebAPI.Model;
using System.Net.Http;
using BasicWebAPI.Service;

namespace BasicWebAPI.Controllers
{
    
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/Book
        IService _service;
        public BookController()
        {
            _service = new BookService();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetBookList());
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
           
            return _service.GetBookById(id);
        }

        // POST: api/Book
        [HttpPost]
        public string Post([FromBody] Book book)
        {
              return _service.AddNewBook(book);
        }

        //// PUT: api/Book/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Book book)
        {
            return _service.UpdateBook(id,book.name);
        }

        ///DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _service.DeleteBook(id);
        }
    }
}
