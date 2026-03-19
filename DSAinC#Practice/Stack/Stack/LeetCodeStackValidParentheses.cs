public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketCheck = new Dictionary<char, char>()
        {
            {')','('},
            {']','['},
            {'}','{'}
        };

        //traverse i/p str
        foreach (char c in s)
        {
            if (bracketCheck.ContainsKey(c))
            {
                // stack not empty + bracket match
                if (stack.Count > 0 && stack.Peek() == bracketCheck[c])
                {
                    stack.Pop();// remove current bracket from stack
                }
                else
                {
                    return false;
                }
            }
            else// it is a opening bracket stored in key of dict  
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;//return true only if stack is empty
    }
}