namespace BirdSancutary
{
    interface ISwimable
    {
        void Swim();
    }

    interface IFlyable
    {
        void Fly();
    }

    abstract class Bird
    {
        public string Name { get; }

        public Bird(string name)
        {
            this.Name = name;
        }
    }

    class Eagle : Bird, IFlyable
    {
        public Eagle(string name) : base(name)
        { }

            public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }

    }

    class Duck : Bird, ISwimable , IFlyable
    {
        public Duck(string name) : base(name) { }
        public void Swim()
        {
            Console.WriteLine($"{Name} is Swimming");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }

    class Penguin: Bird, ISwimable
    {
        public Penguin (string name) : base(name) { }
        public void Swim()
        {
            Console.WriteLine($"{Name} is Swimming");
        }
    }

    class BirdSanctuary
    {
        private List<Bird> birds = new List<Bird>();

        public void AddBird(Bird bird)
        {
            birds.Add(bird);
        }

        public void ShowFlyingBirds()
        {
            Console.WriteLine("Flying Birds");

            foreach (Bird bird in birds)
            {
                if (bird is IFlyable )
                {
                    Console.WriteLine(bird.Name) ;
                }
            }
        }

        public void ShowSwimmingBirds()
        {
            Console.WriteLine("Swimming Birds");
            foreach (Bird bird in birds)
            {
                if (bird is ISwimable)
                {
                    Console.WriteLine(bird.Name);
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            BirdSanctuary sancutary = new BirdSanctuary();
            sancutary.AddBird( new Eagle("X Eagle"));
            sancutary.AddBird( new Duck("Y Duck"));
            sancutary.AddBird( new Penguin("Z Penguin"));

            sancutary.ShowFlyingBirds();
            sancutary.ShowSwimmingBirds();


        }
    }
}
