using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    class Flight<T> //generic class for flights 
    {
        private T flightNumber; // flight number can be any T type data
        private string departure;
        private string destination;

        public Flight(T flightNumber, string departure, string destination)
        {
            this.flightNumber = flightNumber;
            this.departure = departure;
            this.destination = destination;
        }

        public T GetFlightNumber() => flightNumber; //return flight number

        public void DisplayFlightInfo()
        {
            Console.WriteLine($"Flight Number{flightNumber} | From {departure} | To {destination} ");
        }
    }

    class Booking<T>
    {
        private T bookingId;
        private Flight<object> flight;
        private string passengerName;

        public Booking(T bookingId, Flight<object> flight, string passengerName) 
        {
            this.bookingId = bookingId;
            this.flight = flight;
            this.passengerName = passengerName;
        }

        public void DisplayBookingInfo()
        {
            Console.WriteLine($"Booking ID{bookingId} | Passenger Name: {passengerName}");
            flight.DisplayFlightInfo();
        }
    }

    class FlightManager<T> where T : struct
    {
        private List<Flight<T>> flights = new List<Flight<T>> (); // list of flight of t objects

        public void AddFlight(Flight<T> flight) => flights.Add(flight); // lambada method to add flights to list

        public void DisplayAllFLights()
        {
            foreach (var flight in flights)
            {
                flight.DisplayFlightInfo();
            }
        }
    }  

    class FlightUtility
    {
        public static void DisplayFlightDetails<T>(List<Flight<T>> flights)
        {
            foreach ( var flight in flights)
            {
                flight.DisplayFlightInfo();
            }
        }
    }
    

    internal class FlightBookingGeneric
    {
        static void Main()
        {
            Flight<int> flight1 = new Flight<int>(101, "New York", "London");
            Flight<string> flight2 = new Flight<string>("AA202", "Los Angeles", "Tokyo");

            Booking<int> booking1 = new Booking<int>(

                5001,
                new Flight<object>(101, "New York", "London"),
                "John Doe"
            );

            Booking<string> booking2 = new Booking<string>(
                "B102",
                new Flight<object>("AA202", "Los Angeles", "Tokyo"),
                "Jane Smith"
            );

            booking1.DisplayBookingInfo();
            Console.WriteLine("----------------");
            booking2.DisplayBookingInfo();

            Console.WriteLine("\n--- Flight Management ---");
            FlightManager<int> manager = new FlightManager<int>();
            manager.AddFlight(flight1);

            manager.DisplayAllFLights();
        }
    }
}
