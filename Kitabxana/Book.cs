using System;
using System.Collections.Generic;
using System.Text;

namespace Kitabxana
{
    class Book : Product
    {

        public Book(string name, int no,int count, double price, string genre) : base(name, no, price, count)
        {
            this.Genre = genre;
        }
        public string Genre;
    }
}
    
