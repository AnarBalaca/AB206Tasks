using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB206LibraryTask.Models
{
    internal abstract class Product
    {
        private string name;
        private double price;

        protected Product(string name , double price)
        {
            Name = name;
            Price = price;
            
        }
        public string Name 
        { 
            get 
            {
                return name;
            }
            set 
            {
                if (value.Length > 2 && value.Length <99) 
                {
                    name = value;

                }
            }
        }
        public double Price 
        {
            get
            {
                return price;
            }
            set
            {
                if (value> 0)
                {
                    price = value;

                }
            }
        }

        public abstract string GetInfo();

    }
}
