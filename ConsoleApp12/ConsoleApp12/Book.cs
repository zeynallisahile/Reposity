using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Book
    {
        private int _no;
        public int No { get; }
        public Book()
        {
           No=_no ;
            _no++;
        }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public Enum Genre { get; set; }
    }
}
