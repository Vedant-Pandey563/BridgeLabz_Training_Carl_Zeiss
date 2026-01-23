namespace Level1oops
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(Person OtherPerson)
        {
            this.name = OtherPerson.name;
            this.age = OtherPerson.age;
        }

        public void Display()
        {
            Console.WriteLine("Person Name:" + name);
            Console.WriteLine("Person Age:" + age);
        }
    }
    class Program
     {        
        static void Main(string[] args)
        {
            Person person1 = new Person("A", 24);
            Person person2 = new Person(person1);
            Console.WriteLine("Person 1 :");
            person1.Display();

            Console.WriteLine("Person 2 :");
            person2.Display();
        }
    }
}
