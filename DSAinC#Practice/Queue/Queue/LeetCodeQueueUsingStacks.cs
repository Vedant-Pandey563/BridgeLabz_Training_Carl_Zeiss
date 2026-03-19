public class MyQueue
{
    Stack<int> s1;
    Stack<int> s2;
    public MyQueue()
    {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }

    public void Push(int x)
    {
        s1.Push(x);
    }

    public int Pop()
    {
        while (s1.Count > 1)
        {
            s2.Push(s1.Pop());
        }
        int pop = s1.Pop();
        while (s2.Count > 0)
        {
            s1.Push(s2.Pop());
        }

        return pop;
    }

    public int Peek()
    {
        while (s1.Count > 1)
        {
            s2.Push(s1.Pop());
        }
        int peek = s1.Peek();
        while (s2.Count > 0)
        {
            s1.Push(s2.Pop());
        }

        return peek;
    }

    public bool Empty()
    {
        if (s1.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */