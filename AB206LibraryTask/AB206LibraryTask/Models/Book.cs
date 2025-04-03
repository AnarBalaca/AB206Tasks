using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB206LibraryTask.Models
{
    internal class Book : Product
    {
        private string  genre;

        public string  Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }



        public Book(string name, double price , string genre , string author) : base(name, price)
        {

            Genre = genre;
            Author = author;
        }

        public override string GetInfo()
        {
            return $"name: {name}, Price: {Price} ,Genre: {Genre} ,Author: {Author}";
        }
    }
}
