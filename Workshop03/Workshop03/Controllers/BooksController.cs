using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop03.Interfaces;
using Workshop03.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Workshop02.Controllers
{
    public class BooksController : Controller
    {
        private IBookStore _bookStore = new BookStore();

        public void BookStore(IBookStore bookStore)
        {
            _bookStore = bookStore;
        }

        // GET: /<controller>/
		public List<Book> Index()
		{
            BuyBooksOnOpening();
            return _bookStore.ListAll();
        }

        private void BuyBooksOnOpening()
        {
            if(_bookStore.CountAll() == 0)
            {
                _bookStore.Add(new Book("Der Herr der Ringe - Die Gefährten", "J. R. R. Tolkien"));
                _bookStore.Add(new Book("Der Herr der Ringe - Die zwei Türme", "J. R. R. Tolkien"));
                _bookStore.Add(new Book("Der Herr der Ringe - Die Rückkehr des Königs", "J. R. R. Tolkien"));
            }
        }
    }
}