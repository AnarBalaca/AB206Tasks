using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB206LibraryTask.Models.Journal
{
    internal class Journal : Product
    {
        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public Journal(string name, double price , string company) : base(name, price)
        {
            Company = company;
        }

        public override string GetInfo()
        {
            return $"name: {name}, Price: {Price} , Company: {Company}";
        }
    }
}
