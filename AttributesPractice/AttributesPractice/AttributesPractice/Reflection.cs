using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace AttributesPractice
{
    class Employee
    {
        public int Id;
        public string Name {  get; set; }

        public void Show()
        {
            Console.WriteLine("Hello There");
        }

        public Employee()
        {
            Id = 0;
            Name = "a";
        }
    }
    internal class Reflection
    {
        static void Main(string[] args)
        {
            Type t = typeof(Employee);

            Console.WriteLine("Class Name :" +t.Name);
            Console.WriteLine("NameSpace :" +t.Namespace);


            Console.WriteLine("Class method info");
            MethodInfo[] methods = t.GetMethods();

            foreach (MethodInfo m in methods)
            {
                Console.WriteLine();
                Console.Write("Method Name " +m.Name);
                //Console.Write(" , Method return type " + m.ReturnType);
                //Console.Write(" , Method return parameter " + m.ReturnParameter);
                //Console.Write(" , Method Metadata token " + m.MetadataToken);
                //Console.WriteLine(" , Method Declare type " + m.DeclaringType);
            }
            Console.WriteLine();


            Console.WriteLine("Getting property info");
            PropertyInfo[] prop = t.GetProperties();
            foreach(PropertyInfo p in prop)
            {
                Console.WriteLine();
                Console.WriteLine("Property Name " +p.Name);
                Console.WriteLine("Property Module " +p.Module);
            }
            Console.WriteLine();

            Console.WriteLine("Getting field info");
            FieldInfo[] fields = t.GetFields();
            foreach(FieldInfo f in fields)
            {
                Console.WriteLine();
                Console.WriteLine("Field Name " +f.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Getting Constructor info");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach(ConstructorInfo c in constructors)
            {
                Console.WriteLine("Constructor name " +c.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Object and Method using activator in relfection");
            object obj = Activator.CreateInstance(t);
            MethodInfo m2 = t.GetMethod("Show");
            m2.Invoke(obj, null);

            Console.WriteLine();

            Console.WriteLine("Property access using Reflection");
            PropertyInfo p2 = t.GetProperty("Name");
            p2.SetValue(obj, "PigeonDoctor");
            Console.WriteLine(p2.GetValue(obj));
            Console.WriteLine();

            Console.WriteLine("Attribute using Reflections");
            object[] attrs = t.GetCustomAttributes(false);
            foreach(object attr in attrs)
            {
                Console.WriteLine(attr.GetType().Name);
            }
            Console.WriteLine();

            Console.WriteLine("Accesing Assembly Info in Reflections");
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();
            foreach(Type ty in types)
            {
                Console.WriteLine("Assembly type name : " +ty.Name);
            }
            Console.WriteLine();
        }
    }
}
