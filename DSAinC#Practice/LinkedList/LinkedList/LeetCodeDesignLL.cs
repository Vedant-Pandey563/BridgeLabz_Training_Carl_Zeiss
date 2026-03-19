class Node // class to make node 
{
    public int val;
    public Node next;

    public Node(int val)
    {
        this.val = val;
        this.next = null;
    }
}
public class MyLinkedList
{
    private Node head;
    private int size;

    public MyLinkedList()
    {
        head = null;
        size = 0;
    }

    public int Get(int index)
    {
        if (index < 0 || index >= size)
        {
            return -1;
        }

        Node curr = head;

        for (int i = 0; i < index; i++)
        {
            curr = curr.next;
        }

        return curr.val;
    }

    public void AddAtHead(int val)
    {
        Node newNode = new Node(val);

        newNode.next = head;

        head = newNode;

        size++;
    }

    public void AddAtTail(int val)
    {

        if (head == null)
        {
            AddAtHead(val);
            return;
        }

        Node newNode = new Node(val);
        Node curr = head;

        while (curr.next != null)
        {
            curr = curr.next;
        }
        curr.next = newNode;
        size++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > size) return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        Node newNode = new Node(val);
        Node curr = head;

        for (int i = 0; i < (index - 1); i++)
        {
            curr = curr.next;
        }

        newNode.next = curr.next;
        curr.next = newNode;
        size++;

    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= size)
        {
            return;
        }

        if (index == 0)
        {
            head = head.next;
        }
        else
        {
            Node curr = head;
            for (int i = 0; i < (index - 1); i++)
            {
                curr = curr.next;
            }

            curr.next = curr.next.next;
        }

        size--;

    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */