﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEducation.Models
{
    public interface IBookService
    {
        List<Book> GetBooks();       
    }
}
