namespace Inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }

    }

    class Dog : Animal 
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat is Meowing");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();  
            cat.Meow();
            cat.Eat();
        }
    }
}
