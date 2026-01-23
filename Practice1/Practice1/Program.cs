// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using System;
class Example
{
    int instanceVar = 10;
    static int staticVar = 20;

    public static void staticMethod()
    {
        Console.WriteLine("Static Method");
       
        Console.WriteLine(staticVar);

        Console.WriteLine(instanceVar); 
    }

    public void instanceMethod()
    {
        Console.WriteLine("Instance Method");
        Console.WriteLine(staticVar); 
        Console.WriteLine(instanceVar);
    }

}