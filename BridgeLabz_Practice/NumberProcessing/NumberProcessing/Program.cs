//input numbers as list through multiple stages
// filter negatives , sqaure values, sort 
//use inheritance , method overriding compostion

using System;
using System.Collections.Generic;

// Base
class Number
{
    public virtual List<int> Process(List<int> numbers)
    {
        return numbers;
    }
}

// Negative
class Negative : Number
{
    public override List<int> Process(List<int> numbers)
    {
        List<int> result = new List<int>();

        foreach (int n in numbers)
        {
            if (n >= 0)
            {
                result.Add(n);
            }
        }

        return result;
    }
}

// Square 
class Square : Negative
{
    public override List<int> Process(List<int> numbers)
    {
        numbers = base.Process(numbers);
        List<int> result = new List<int>();
        foreach (int n in numbers)
        {
            result.Add(n * n);
        }

        return result;
    }
}

// Sort 
class Sort : Square
{
    public override List<int> Process(List<int> numbers)
    {
        numbers = base.Process(numbers);
        numbers.Sort();
        return numbers;
    }
}

// Main
class Program
{
    static void Main()
    {
        List<int> input = new List<int> { -5, 3, 1, -2, 6, 7, 6 };

        Number processor = new Sort();
        List<int> output = processor.Process(input);

        foreach (int n in output)
        {
            Console.Write(n + " ");
        }
    }
}
