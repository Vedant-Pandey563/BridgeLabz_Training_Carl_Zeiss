using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciplesPractice
{
    public interface IProduct //product interface
    {
        string Operation();
    }

    //concrete product a
    class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "Result From ConcreteProductA";
        }
    }
    //concrete product b
    class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "Result From ConcreteProductB";
        }
    }

    //creator , abstract factory class
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();

            string result = "Creator worked with " + product.Operation();

            return result;
        }
    }

    // Concrete creator a
    class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    // Concrete creator b
    class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
    internal class FactoryPrinciple
    {
        static void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class.");
            Console.WriteLine(creator.SomeOperation());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("App launched with ConcreteCreatorA");
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine();

            Console.WriteLine("App launched with ConcreteCreatorB");
            ClientCode(new ConcreteCreatorB());
        }
    }
}
