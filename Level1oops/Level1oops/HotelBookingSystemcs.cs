using System;
using System.Collections.Generic;
using System.Text;

namespace Level1oops
{
    class HotelBookingSystem
    {
        private string guestName;//pvt atributes
        private string roomType;
        private int noOfNights;


        public HotelBookingSystem ()//default constructor
        {
            guestName = "Not Applicable";
            roomType = "Not Applicable";
            noOfNights = 0;

        }
        public HotelBookingSystem(string guestName,string roomType, int noOfNights) //parameterized constructor
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.noOfNights = noOfNights;
        }

        public HotelBookingSystem (HotelBookingSystem  CopyBooking) //copy constructor
        {
            this.guestName = CopyBooking.guestName;
            this.roomType = CopyBooking.roomType;
            this.noOfNights = CopyBooking.noOfNights;
        }

        public void DisplayBookingDetails()// display method
        {
            Console.WriteLine("Guest Name : "+guestName);
            Console.WriteLine("Room Type : " + roomType);
            Console.WriteLine("Number of Nights : " + noOfNights);
        }

    }

    class Program2
    {
        static void Main(string[] args)
        {
            HotelBookingSystem booking1 = new HotelBookingSystem(); //obj 1 default constructor
            HotelBookingSystem booking2 = new HotelBookingSystem("a", "Suite", 4); // obj 2 parameterized constructor
            HotelBookingSystem booking3 = new HotelBookingSystem(booking2);//obj 3 copy constructor

            Console.WriteLine("Booking1 Details");
            booking1.DisplayBookingDetails();
            Console.WriteLine("Booking2 Details");
            booking2.DisplayBookingDetails();
            Console.WriteLine("Booking3 Details");
            booking3.DisplayBookingDetails();

        }
    }
}
