#define DEBUG

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AttributesPractice
{
    internal class ConditionalExample
    {
        [Conditional("DEBUG")]
        static void DebugMethod()
        {
            Console.WriteLine("Debug Mode");
        }

        static void Main(string[] args)
        {
            DebugMethod();
        }
    }
}
