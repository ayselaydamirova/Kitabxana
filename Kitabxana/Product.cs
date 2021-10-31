using System;
using System.Collections.Generic;
using System.Text;

namespace Kitabxana
{
    class Product
  {    
        public Product(string name,int no,double price,int count)
        {
            this.Name = name;
            this.No = no;
            this.Price = price;
            this.Count = count;

        }
        
            
      
       

        public string Name;
        public int No;
        public double Price;
        public int Count;
        public string GetInfo()
        {
            return $"Name: {this.Name} - No:{this.No} - Price: {this.Price} - Count: {this.Count}";
        }
    }
}
}
