using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Usedcars : Car
    {
        private double mileage;
        private string exit;


        public double Mileage
        {


            set { mileage = value; }
            get { return mileage; }


        }

        public string Exit
        {
            set { exit = value; }
            get { return exit; }
        }
        public Usedcars(double Mileage)
        {
            mileage = 0;
        }
        public Usedcars(string Exit)
        {
            exit = "";
        }
        public Usedcars(string CarMake, string CarModel, int Caryear, double CarPrice, double milg)
        {

            this.Make = CarMake;
            this.Model = CarModel;
            this.Year = Caryear;
            this.Price = CarPrice;
            Mileage = milg;
        }
        
        public override void CarInfo()
        {

            Console.WriteLine(Make + " " + Model + " " + Year + " " + Price.ToString() +" " + "(Used)" + " " + Mileage.ToString() + " " +"Miles");

        }
    }
}
