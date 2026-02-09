namespace GenericsPractice
{
    internal class Program
    {
        static void PrintAnything<T>(T item)
        {
            Console.WriteLine("Generic Method Output: " + item);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Generics");

            var MyGenericIntClass = new MyGenericClass<int>();
            MyGenericIntClass.Name = "a";
            MyGenericIntClass.Data = 4;

            var MyGenericStringClass = new MyGenericClass<string>();
            MyGenericStringClass.Name = "b";
            MyGenericStringClass.Data = "four";

            Console.WriteLine(4*MyGenericIntClass.Data);
            Console.WriteLine(MyGenericStringClass.Data);

            Console.WriteLine("Reference Type ");
            ReferenceBox<string> b1 = new ReferenceBox<string>();
            ReferenceBox<object> b2 = new ReferenceBox<object>();
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine();

            Console.WriteLine("Value Type");
            ValueBox<int> v1 = new ValueBox<int>();
            ValueBox<double> v2 = new ValueBox<double>();
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine();


            Console.WriteLine("Parameterless Constructor Type");
            Factory<Car> f = new Factory<Car>();
            Car c = f.CreateObject();
            Console.WriteLine(c);
            Console.WriteLine();


            Console.WriteLine("Inherit from Base Class Type");

            Zoo<Dog> z1 = new Zoo<Dog>();
            Zoo<Cat> z2 = new Zoo<Cat>();

            Console.Write("Dog says: ");
            z1.MakeSpeak(new Dog());

            Console.Write("Cat says: ");
            z2.MakeSpeak(new Cat());
            Console.WriteLine();


            // genric method call
            Console.WriteLine("Generic Print Method ");
            PrintAnything("abcd");
            PrintAnything(1.92);

        }
    }

    class MyGenericClass <T>
    {
        public string Name { get; set; }
        public T Data { get; set; }
    }

    class ReferenceBox<T> where T : class // t must be reference type like string object
    {
        public T Value;

        public bool IsNull()
        {
            return Value == null;
        }

        public override string ToString()
        {
            return $"ReferenceBox: Value = {(Value == null ? "null" : Value.ToString())}";
        }
    }

    class ValueBox<T> where T : struct// t must be value type int bool double 
    {
        public T value;

        public T DefaultValue()
        {
            return default(T);
        }

        public override string ToString()
        {
            return $"ValueBox: value = {value}";
        }
    }
    class Factory<T> where T : new() //T must have a public no-argument constructor
    {
        public T CreateObject()
        {
            return new T();
        }
    }


    class Car
    {
        public Car() { }

        public override string ToString()
        {
            return "Car object created successfully";
        }
    }


    class Zoo<T> where T : Animal //call methods of the base class safely inside generic code
    {
        public void MakeSpeak(T animal)
        {
            animal.Speak();
        }

        public override string ToString()
        {
            return "Zoo instance created";
        }
    }

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    class Dog : Animal { }
    class Cat : Animal { }
}
