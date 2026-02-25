using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LINQPractice.LinqBasics
{
    class Person
    {
        public string Name;
        public string City;
    }
    internal class AddressBookQ
    {
        static void Main(string[] args)
        {

                List<Person> persons = new List<Person> {
                new Person{Name="A",City="Chennai"},
                new Person{Name="B",City="Mumbai"},
                new Person{Name="C",City="Delhi"},
                new Person{Name="D",City="Delhi"},
                new Person{Name="E",City="Bengaluru"},
                new Person{Name="F",City="Chennai"},
                new Person{Name="G",City="Mumbai"},
            };

            var result = persons.GroupBy(p => p.City)
                                .Select(group => new
                                {
                                    City = group.Key,
                                    Name = group.OrderBy(p=>p.Name)
                                });

            foreach(var r in result)
            {
                Console.WriteLine($"City {r.City}");
                foreach(var name in r.Name)
                {
                    Console.Write($" Name : {name.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
