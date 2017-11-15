﻿using System;
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
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return Name + " - " + Author;
        }

        [Key]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; } = String.Empty;
        public string Author { get; private set; } = String.Empty;
    }
}
