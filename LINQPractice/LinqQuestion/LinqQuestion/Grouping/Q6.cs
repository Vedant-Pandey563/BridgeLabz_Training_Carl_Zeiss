using System;
using System.Collections.Generic;
using System.Text;

//6. Given a list of strings, group them by their length and display each group.

namespace LinqQuestion.Grouping
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {"cat","apple","monkey","Mat","barca","six","seven","qwerty","a"};

            var result = list.GroupBy(s => s.Length)
                             .OrderBy(group=>group.Key)
                             .Select(group => new 
                             {
                                 StringLength = group.Key,
                                 StringWord = group.ToList()
                             });

            foreach( var item in result )
            {
                Console.WriteLine($"Length : {item.StringLength}");
                foreach(var word in  item.StringWord )
                {
                    Console.WriteLine($"Word : {word}");
                }
                Console.WriteLine();
            }
        }
    }
}
