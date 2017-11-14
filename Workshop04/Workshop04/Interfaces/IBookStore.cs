using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop04.Models;

namespace Workshop04.Interfaces
{
    public interface IBookStore
    {
        List<Book> ListAll();
        void Add(Book book);
        int CountAll();
        Book GetByName(string bookTitle);
    }
}
