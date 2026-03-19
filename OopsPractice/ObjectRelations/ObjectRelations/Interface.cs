using System;

interface Vehicle
{
    void Move();   // contract 
}

class Car : Vehicle   // Interface realization
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Program
{
    static void Main()
    {
        // Interface reference
        Vehicle v = new Car();
        v.Move();
    }
}
