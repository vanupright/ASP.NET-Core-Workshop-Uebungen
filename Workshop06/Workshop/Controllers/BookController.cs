using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workshop.Interfaces;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Produces("application/json")]
    [Route("api/Book")]
    public class BookController : Controller
    {
        private readonly IBookStore _bookStore;
        public BookController(IBookStore bookStore)
        {
            _bookStore = bookStore;
            BuyBooksOnOpening();
        }
        private void BuyBooksOnOpening()
        {
            if (!_bookStore.ListAll().Any())
            {
                _bookStore.Add(new Book("Der Herr der Ringe - Die Gefährten", "J. R. R. Tolkien"));
                _bookStore.Add(new Book("Der Herr der Ringe - Die zwei Türme", "J. R. R. Tolkien"));
                _bookStore.Add(new Book("Der Herr der Ringe - Die Rückkehr des Königs", "J. R. R. Tolkien"));
            }
        }
        [HttpGet]
        public IEnumerable<Book> Index()
        {
            return _bookStore.ListAll();
        }

        [HttpPost]
        public IEnumerable<Book> AddBook([FromBody] Book book)
        {
            _bookStore.Add(book);
            return _bookStore.ListAll();
        }
    }


}