using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab206.Models
{
    internal class Gallery 
    {
        Car[] cars;
        public Gallery()
        {
            cars = new Car[0];
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length+1);
            cars[^1] = car;

        }

        public void ShowFullCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }


        public string Filter(string brand)
        {
            foreach (var car in cars)
            {
                if (car.Brand == brand)
                {
                  return car.ToString();
                }
            }
            return "Tapmadim";
        }
        public string Filter(double mile)
        {
            foreach (var car in cars)
            {
                if (car.Mile == mile)
                {
                    return car.ToString();
                }
            }
            return "Tapmadim";
        }





    }
}
