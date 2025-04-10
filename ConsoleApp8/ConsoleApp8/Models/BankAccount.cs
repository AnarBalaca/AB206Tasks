using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Models
{
    public class BankAccount
    {

		private static int _id;
		public int Id;
        public BankAccount(string customerName , double balance)
        {
			++_id;
			Id = _id;
			CustomerName = customerName;
			Balance = balance;
        }
        private string customerName;

		public string CustomerName
		{
			get { return customerName; }
			set { customerName = value; }
		}

		private double balance;

		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}



	}
}
