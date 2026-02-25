using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AttributesPractice
{
    class BasicReflection
    {

        [Obsolete]
        static void Test()
        { }

        static void Main(string[] args)
        {
            MethodInfo method = typeof(BasicReflection).GetMethod("Test");

            object[] attributes = method.GetCustomAttributes(false);

            foreach (object attribute in attributes)
            {
                Console.WriteLine(attribute.GetType().Name);
            }
        }

    }
}
