namespace HelloWorld
{
    internal class Program
    {
        public static int[] FindAllIndexes(string text, char ch)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ch) count++;
            }

            int[] indexes = new int[count];
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ch) indexes[j++] = i;
            }
            return indexes;
        }

        static void Main(string[] args)
        {
            /* string s = "1";
             int i = Convert.ToInt32(s);
             int j = int.Parse(s);
             Console.WriteLine(s);
             Console.WriteLine(i);
             Console.WriteLine(j);



             string text = "\"hello 's \", said abc";
             Console.WriteLine(text);

             string text2 = @"""hello 's "", said abc ";
             Console.WriteLine(text2);

             
            Console.Write("Enter your name and favorite quote: ");
            string name = Console.ReadLine();
            Console.WriteLine(name + " said, \"" + Console.ReadLine()?.Trim() + "\"");
             

            try
            {
                int divideByZero , a=5 , b=0;
                divideByZero = a/b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            

            try
            {
                using (StreamReader sr = new StreamReader("file.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            */

            Console.Write("Enter a text: ");
            string text = Console.ReadLine();
            Console.Write("Enter a character to find its occurrences: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int[] indexes = FindAllIndexes(text, ch);

            Console.WriteLine($"Indexes of character '{ch}': {string.Join(", ", indexes)}");


        }
    }
}
