using System;
using System.Collections.Generic;
using System.Text;

namespace AttributesPractice
{
    class AuthorAttribute:Attribute
    {
        public string Name;

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [Author("Yo")]
    internal class CustomAttribute
    {
        static void Main(string[] args)
        {
            Type type = typeof(CustomAttribute);

            object[] attributes = type.GetCustomAttributes(false);
            
            foreach (object attribute in attributes)
            {
                AuthorAttribute author = (AuthorAttribute)attribute;

                Console.WriteLine(author.Name);
            }
        }
    }
}
