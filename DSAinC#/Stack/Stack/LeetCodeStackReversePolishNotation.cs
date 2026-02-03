public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> s = new Stack<int>();

        foreach (string c in tokens)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/")
            {
                int left = s.Pop();
                int right = s.Pop();
                int temp = 0;
                switch (c)
                {
                    case "+":

                        temp = right + left;
                        break;

                    case "-":

                        temp = right - left;
                        break;

                    case "*":

                        temp = right * left;
                        break;

                    case "/":

                        temp = right / left;
                        break;

                }//switch over 

                s.Push(temp);
            }
            else
            {
                s.Push(int.Parse(c));
            }
        }

        return s.Pop();

    }
}