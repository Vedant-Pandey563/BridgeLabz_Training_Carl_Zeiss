
public class MinStack
{
    private Stack<int> s = new Stack<int>();

    public MinStack()
    {
        Stack<int> s = new Stack<int>();
    }

    public void Push(int val)
    {
        s.Push(val);
    }

    public void Pop()
    {
        s.Pop();
    }

    public int Top()
    {
        return s.Peek();
    }

    public int GetMin()
    {
        return s.Min();

    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */