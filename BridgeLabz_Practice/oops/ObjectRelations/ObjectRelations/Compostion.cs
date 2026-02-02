using System;
using System.Collections.Generic;

class Room
{
    public string RoomType { get; set; }

    public Room(string type)
    {
        RoomType = type;
    }
}

class House
{
    public string Address { get; set; }
    private List<Room> rooms;

    public House(string address)
    {
        Address = address;

        // Compositioon
        rooms = new List<Room>();
        rooms.Add(new Room("Bedroom"));
        rooms.Add(new Room("Kitchen"));
    }

    public void ShowRooms()
    {
        Console.WriteLine($"House at {Address} has:");
        foreach (var room in rooms)
        {
            Console.WriteLine(room.RoomType);
        }
    }
}

class Program
{
    static void Main()
    {
        House h1 = new House("Blr");
        h1.ShowRooms();
    }
}
