// Universal Rempte
using System;
using System.Collections.Generic;

class Warrior
{
    public double attack { get; set; }
    public virtual void Attack(double attack)
    {
        attack = +5;
    }
}

class Paladin : Warrior
{
    public double heal { get; set}

    public override void Attack(attack)
    {
        attack = 1.2 * Warrior().Attack();
    }

    public void Heal()
    {
        heal = +30;
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

public class UniversalRemote
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