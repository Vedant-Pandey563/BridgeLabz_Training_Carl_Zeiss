public class MyStack
{
    Queue<int> q;
    public MyStack()
    {
        q = new Queue<int>();
    }

    public void Push(int x)
    {
        q.Enqueue(x);

        if (q.Count > 1)
        {
            for (int i = 0; i < (q.Count() - 1); i++)
            {
                q.Enqueue(q.Dequeue());
            }
        }
    }

    public int Pop()
    {
        return q.Dequeue();
    }

    public int Top()
    {
        return q.Peek();
    }

    public bool Empty()
    {
        if (q.Count() == 0)
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
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */