using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab206.Models
{
    internal abstract class Vehicle
    {
		private string model;

		public string Model
		{
			get
			{ 
				return model;
			}

			set 
			{
				if (value.Length >= 3 && value.Length < 30)
				{
					model = value;
				}
				else
                {
                    Console.WriteLine("Ele masin ol ki Hec kim arxanca soz demesin A.Y.E(BMW)");
                }
            }
		}

		private string brand;

		public string Brand
		{
			get { return brand; }

            set
            {
                if (value.Length >= 3 && value.Length < 30)
                {
                    brand = value;
                }
                else
                {
                    Console.WriteLine("Ele masin ol ki Hec kim arxanca soz demesin A.Y.E(BMW)");
                }
            }
        }

		private double mile;
        protected Vehicle()
        {
            
        }
        public Vehicle(string model, string brand, double mile)
        {
            Model = model;
            Brand = brand;
            Mile = mile;
        }

        public double Mile
		{
			get { return mile; }
		
			set
			{
				if (value >0)
				{
                    mile = value;
                }			
			}
		}


		public abstract void ShowFullInfo();



	}
}
