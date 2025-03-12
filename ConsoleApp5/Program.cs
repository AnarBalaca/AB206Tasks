using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. 1 - den M - edek ededler icerisinde 15 - e bolunenlerin ededi ortasini geri qaytarsan method
            //2.N - den 100 - edek ededler icerisinde 21 - e bolunen ededin olub olmadigini tapib geri qaytaran method
            //3.Verilmis ededin reqemlerinin cemini tapib ekranda yazdirin(Mes: 234-> 9)
            //4.Arrayde 2e bolunen ededleri tapib hasilini geri qaytaran method
            double a = 3;
            double b = 1;
            double c = 5;
            double r = 4.2;


            Console.WriteLine(Area(a));
            Console.WriteLine(Area(a,b));
            Console.WriteLine(Area(a,b,c));
            Console.WriteLine(Area(a, b, c ,r));
            
          



      
        }


        #region AreaTask
        //4.Area deyə Method(lar) yaradın
        //a.Çevrənin sahəsi -S = p * r² (p = 3)
        //b.Düzbucaqlının sahəsi -S = a * b
        //c.Düzbucaqlı paralelpipedin tam səthinin sahəsi - S = 2(a * b + a * c + b * c)
        //d.Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2


        const double PI = Math.PI;

        public static double Area(double r)
        {
            double s = PI * Math.Pow(r, 2);

            return s;

        }

        public static double Area(double a, double b)
        {
            double s = a * b;
            return s;

        }

        public static double Area(double a, double b, double c)
        {
            double s = 2 * (a * b + a * c + b * c);
            return s;

        }

        public static double Area(double r, double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = p * r;
            return s;
        }

        #endregion


        #region OtherTask


        //public static void GetProduct(int[] arr)
        //{
        //    int product = 1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            product *= arr[i];
        //        }

        //    }
        //    Console.WriteLine(product);

        //}

        //public static int GetProduct(int[] arr )
        //{
        //    int product = 1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            product *= arr[i];
        //        }

        //    }
        //   return product;

        //}

        #endregion


    }
}
