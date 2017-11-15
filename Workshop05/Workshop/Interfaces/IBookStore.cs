using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;

namespace Workshop.Interfaces
{
    public interface IBookStore
    {
        IEnumerable<Book> ListAll();
        void Add(Book book);
        //Book GetByName(string bookTitle);
    }
}
