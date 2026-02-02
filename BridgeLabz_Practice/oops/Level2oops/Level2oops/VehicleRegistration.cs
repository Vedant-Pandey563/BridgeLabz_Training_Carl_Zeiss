using System;
using System.Collections.Generic;
using System.Text;

namespace Level2oops
{
    internal class Vehicle
    {
        private string ownerName;
        private string vehicleNumber;
        public static int registerFee = 500;//static variable

        public Vehicle (string ownerName, string vehicleNumber)
        {
            this.ownerName = ownerName; 
            this.vehicleNumber = vehicleNumber; 
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name : " + ownerName);
            Console.WriteLine("Vehicle Number : " + vehicleNumber);
            Console.WriteLine("Registration Fee : " + registerFee);
        }

        public static void UpdateRegisterFee(int newFee)
        {
            registerFee = newFee;
            Console.WriteLine("Registration fee updated to : " + registerFee);
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("A", "NJU34");
            Vehicle vehicle2 = new Vehicle("B", "cfwf2");

            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();

            Vehicle.UpdateRegisterFee(563);
            Console.WriteLine("After updated Registration fees");

            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();

        }
    }
}
