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
        private readonly ApplicationDbContext _dbContext;

        public BookStore(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Book book)
        {
            _dbContext.Book.Add(book);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Book> ListAll()
        {
            return _dbContext.Book.AsEnumerable();
        }

        /*public Book GetByName(string bookTitle)
        {
            return _dbContext.FirstOrDefault(book => book.Name == bookTitle);
        }*/
    }
}
