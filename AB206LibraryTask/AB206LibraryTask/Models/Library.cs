using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB206LibraryTask.Models
{
    internal class Library
    {
        Product[] products = new Product[0];


        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[^1] = product;
        }

        public Product[] GetProductByPrice(double minPrice, double maxPrice)
        {
            Product[] foundedProducts = new Product[0];
            foreach (Product p in products)
            {
                if (p.Price > minPrice && p.Price < maxPrice)
                {
                    Array.Resize(ref foundedProducts, products.Length + 1);
                    products[^1] = p;
                }

            }
            return foundedProducts;
        }


        public Product[] GetProductByName(string name) 
        {

            Product[] foundedProducts = new Product[0];
            foreach (Product p in products)
            {
                if (p.Name == name)
                {
                    Array.Resize(ref foundedProducts, products.Length + 1);
                    products[^1] = p;
                }

            }
            return foundedProducts;

        }

    }
}
