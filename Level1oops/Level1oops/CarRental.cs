using System;
using System.Collections.Generic;
using System.Text;

namespace Level1oops
{
    internal class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;

        public CarRental(string customerName,string carModel,int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        public double RentalCost()
        {
            double DailyCost = 67.0;
            return rentalDays * DailyCost;
        }

        public void DisplayRentalDetails()
        {
            Console.WriteLine("Customer Name : " +customerName);
            Console.WriteLine("Car Model : " + carModel);
            Console.WriteLine("Number of Rental Days : " + rentalDays);
            Console.WriteLine("Total Rental Cost : " + RentalCost());
        }

    }

    class Program3
    {
        static void Main(string[] args)
        {
            CarRental rental1 = new CarRental("abc", "Maruti 800", 5);
            rental1.DisplayRentalDetails();
        }
    }
}
