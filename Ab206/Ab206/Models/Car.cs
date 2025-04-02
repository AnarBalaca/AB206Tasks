using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab206.Models
{
    internal class Car : Vehicle
    {
		private int doorsNum;

        public Car(string model, string brand, double mile , int doorsNum) : base(model, brand, mile)
        {
            DoorsNum = doorsNum;
        }

        public int DoorsNum
		{
			get { return doorsNum; }
			set 
			{
				if (value > 0 && value<5) 
				{
                    doorsNum = value;
                }
			}


		}

        public override void ShowFullInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Model: {Model} Model: {Brand}  Model: {Mile} ";
        }

    }
}
