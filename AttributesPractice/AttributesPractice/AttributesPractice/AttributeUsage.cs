using System;
using System.Collections.Generic;
using System.Text;

namespace AttributesPractice
{

    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Method,
        AllowMultiple = true,
        Inherited = true
        )]
    class InfoAttribute:Attribute
    {
        public string Message;

        public InfoAttribute(string message)
        {
            Message = message;
        }
    }

    [Info("class info")]
    internal class AttributeUsage
    {
        [Info("Method Info")]
        public static void Test() { }
        static void Main(string[] args)
        {
            Test();
        }
    }
}
