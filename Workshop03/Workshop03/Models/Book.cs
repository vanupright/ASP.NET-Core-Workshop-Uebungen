using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Workshop03.Models
{

    public class Book
    {
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
        private Book()
        {
        }

        public string Name { get; private set; } = String.Empty;
        public string Author { get; private set; } = String.Empty;
    }
}
