using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Workshop.Models
{

    public class Book
    {
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            Id = Guid.NewGuid();
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return Name + " - " + Author;
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
