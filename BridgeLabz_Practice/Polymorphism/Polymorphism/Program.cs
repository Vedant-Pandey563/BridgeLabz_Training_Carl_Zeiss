namespace Polymorphism
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();

            Animal  dog = new Dog();

            Animal cat = new Cat();

            ani.Sound();
            dog.Sound();
            cat.Sound();
        }

    }
}
