using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {       //information from which the user will pick the car from

            Car p1 = new Car("Ford".PadRight(10), "Focus".PadRight(10), 2017, 15000);
            Car p2 = new Car("Ford".PadRight(10), "F150".PadRight(10), 2016, 26000);
            Car p3 = new Car("Chevrolet".PadRight(10), "Malibu".PadRight(10), 2017, 18000);

            Usedcars s1 = new Usedcars("Toyota".PadRight(10), "Corolla".PadRight(10), 2001, 1800, 135000);
            Usedcars s2 = new Usedcars("Nissan".PadRight(10), "Maxima".PadRight(10), 2010, 3500, 140200);
            Usedcars s3 = new Usedcars("Nissan".PadRight(10), "350Z".PadRight(10), 2004, 4600, 135000);

            Car[] CarList = new Car[6];
            CarList[0] = p1;
            CarList[1] = p2;
            CarList[2] = p3;

            CarList[3] = s1;
            CarList[4] = s2;
            CarList[5] = s3;





            for (int i = 0; i < CarList.Length; i++)
            {


                CarList[i].CarInfo();


            }
            Console.WriteLine("Which car would you like?");

            string userchoice;
            if (userchoice = CarList[i])

            {

                Console.WriteLine("Excellent!, our department will be in touch shortly");

                int indexToRemove = int.Parse(Console.ReadLine());

                CarList = CarList.Where((source, index) => index != indexToRemove).ToArray();






            }





        }
    }
}
