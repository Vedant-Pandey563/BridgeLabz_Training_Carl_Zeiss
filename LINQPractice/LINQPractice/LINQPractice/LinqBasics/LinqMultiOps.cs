using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPractice.LinqBasics
{
    internal class LinqMultiOps
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Ops");

            int[] numbers = { 5, 2, 8, 1, 10, 3, 6, 9, 4, 7 };

            var result = numbers
                        .Where(n=> n>2) // oly number abpove 2
                        .GroupBy(n => n % 2)// two grps , one for odd,one for even
                        .Select(group => new // transform grp elements , key = remainder and val is sum of odd/eveevn
                        {
                            Key = group.Key,
                            Sum = group.Sum()
                        });

            Console.WriteLine("Result");
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Key} -- {item.Sum} ");
            }

        }
    }
}
