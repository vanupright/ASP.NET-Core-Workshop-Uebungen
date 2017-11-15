using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Interfaces;
using Workshop.Models;

namespace Workshop.Models
{
    public class BookStore : IBookStore
    {
        private readonly List<Book> _listBook;

        public BookStore()
        {
            _listBook = new List<Book>();
        }
        public void Add(Book book)
        {
            _listBook.Add(book);
        }

        public List<Book> ListAll()
        {
            return _listBook;
        }
        public int CountAll()
        {
            return _listBook.Count();
        }

        public Book GetByName(string bookTitle)
        {
            return _listBook.FirstOrDefault(book => book.Name == bookTitle);
        }
    }
}
