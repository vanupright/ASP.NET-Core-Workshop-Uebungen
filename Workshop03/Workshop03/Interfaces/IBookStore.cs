﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop03.Models;

namespace Workshop03.Interfaces
{
    public interface IBookStore
    {
        List<Book> ListAll();
        void Add(Book book);
        int CountAll();
    }
}
