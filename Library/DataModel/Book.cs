﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.DataModel
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }

        public Author Author { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
