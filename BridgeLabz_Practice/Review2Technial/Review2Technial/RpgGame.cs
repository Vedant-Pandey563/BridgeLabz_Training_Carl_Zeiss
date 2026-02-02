//RPG Game
using System;

class Warrior
{
    public virtual double Attack()
    {
        Console.WriteLine("Warrior attacks");
        return 50;
    }
}

class Paladin : Warrior
{
    public override double Attack()
    {
        double baseAttack = base.Attack();
        double boostedAttack = baseAttack * 1.2;

        Console.WriteLine("Paladin attacks");
        return boostedAttack;
    }

    public void Heal()
    {
        Console.WriteLine("Paladin heals");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("RPG Game");

        Warrior w = new Warrior();
        Console.WriteLine("Warrior Attack Power: " + w.Attack());

        Console.WriteLine("Level Up!");

        Paladin p = new Paladin();
        Console.WriteLine("Paladin Attack Power: " + p.Attack());
        p.Heal();
    }
}
