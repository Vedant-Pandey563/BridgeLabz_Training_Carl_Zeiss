namespace subString
{
    internal class Program
    {
        
        static string CreateSubStr(string text, int startIndex, int endIndex)
        {
            string result = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                result += text[i];
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string txt = Console.ReadLine();

            Console.WriteLine("Enter the starting index: ");
            int startIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending index: ");
            int endindex = Convert.ToInt32(Console.ReadLine());

            string subStr = CreateSubStr(txt, startIndex, endindex);

            string builtInSubStr = txt.Substring(startIndex, endindex - startIndex +1);

            Console.WriteLine("Custom Substring: " + subStr);
            Console.WriteLine("Built-in Substring: " + builtInSubStr);
            Console.WriteLine("Are both equal? " + subStr.Equals(builtInSubStr));

        }
    }
}
