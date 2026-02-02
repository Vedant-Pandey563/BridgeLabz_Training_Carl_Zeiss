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
        Console.WriteLine("Paladin heal for 30");
    }
}

public class UniversalRemote
{
    public static void Main(string[] args)
    {
        Console.WriteLine("RPG Game\n");

        Warrior w = new Warrior();
        Console.WriteLine("Warrior Attack : " + w.Attack());

        Console.WriteLine("Level Up to paladin");

        Paladin p = new Paladin();
        Console.WriteLine("Paladin Attack : " + p.Attack());
        p.Heal();
    }
}
