using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop04.Interfaces;

namespace Workshop04.Models
{
    public class BookStore : IBookStore
    {
        private List<Book> _listBook;

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
    }
}
