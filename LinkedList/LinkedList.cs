namespace LinkedListNS;

public class LinkedList()
{
    public Node? Head { get; private set; } = null;

    public int Count { get; private set; } = 0;

    public void AddFirst(string data)
    {
        Node newNode = new(data)
        {
            Next = Head
        };

        Head = newNode;
        Count += 1;
    }

    public void AddLast(string data)
    {
        if (Head is null)
        {
            AddFirst(data);
            return;
        }

        int lastIndex = Count - 1;
        Node lastNode = GetNodeAt(lastIndex);

        // point the next of the last element to the new node
        lastNode.Next = new Node(data);
        Count += 1;
    }

    public void RemoveFirst()
    {
        if (Head is null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Head = Head.Next;
        Count -= 1;
    }

    public void RemoveLast()
    {
        // if there is 0 or 1 element in the list, the behaviour is the same as if we were removing the first element
        if (Count <= 1)
        {
            RemoveFirst();
            return;
        }

        int secondToLastIndex = Count - 2;
        Node secondToLastNode = GetNodeAt(secondToLastIndex);

        // point the Next of the second-to-last node to null
        secondToLastNode.Next = null;
        Count -= 1;
    }

    public string GetValue(int index)
    {
        if (Head is null || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }

        Node current = GetNodeAt(index);

        return current.Data;
    }

    private Node GetNodeAt(int index)
    {
        Node current = Head!;

        for(; index > 0; index -= 1)
        {
            current = current.Next!;
        }

        return current;
    }
}