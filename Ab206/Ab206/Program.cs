using Ab206.Models;

namespace Ab206
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();
            //Vehicle vehicle = new Vehicle();

        }


        public static void Menu()
        {
            int choice;
            string brand;
            string model;
            double mile;
            int doorsnum;
          
            Gallery gallery = new Gallery();


            do
            {

            start:
               
                Console.WriteLine("1.Masin Elave Etmek  2.Masinlarin Siyahisi  3.Masin Axtarmaq  0.EXIT");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {

                    goto start;
                }
                Console.Clear();
                switch (choice)
                {
                    case 0:
                        return;
                        case 1:

                        brand = GetInput("brand");

                        Console.WriteLine("model daxil edin");
                        model = Console.ReadLine();
                        do
                        {
                            
                        } while (!double.TryParse(GetInput("MILE") , out mile));

                        do
                        {
                            Console.WriteLine("DoorsNum Daxil edin");

                        } while (!int.TryParse(Console.ReadLine(), out doorsnum));

                        Car car = new Car(brand , model , mile , doorsnum );
                        gallery.AddCar(car);
                        break;
                    case 2:
                        gallery.ShowFullCars();

                            break;
                        case 3:

                            break;


                    default:
                        break;
                }
            }
            while (true);



        }


        public static string GetInput(string msg)
        {
            Console.WriteLine($"{msg} daxil edin");
            return Console.ReadLine();
        }
    }
}
