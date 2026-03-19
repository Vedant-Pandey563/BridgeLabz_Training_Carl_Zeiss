// Universal Rempte
using System;
using System.Collections.Generic;

abstract class Device
{
    public string Name { get; set; }

    public abstract void Turn_on();
}

class TV : Device
{

    public override void Turn_on()
    {
        Console.WriteLine("TV has been turned on");
    }
}

class Light : Device
{
    public override void Turn_on()
    {
        Console.WriteLine("Light has been turned on");
    }
}

class AC : Device
{

    public override void Turn_on()
    {
        Console.WriteLine("AC has been turned on");
    }
}

class Remote
{
    private List<Device> device = new List<Device>();

    public void AddDevice(Device d)
    {
        device.Add(d);
    }

    public void SwitchOn()
    {
        foreach (Device d in device)
        {
            d.Turn_on();
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Universal Remote");

        Remote r = new Remote();

        r.AddDevice(new TV());
        r.AddDevice(new Light());
        r.AddDevice(new AC());

        r.SwitchOn();
    }
}
