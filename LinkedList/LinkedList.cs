namespace LinkedListNS;

public class LinkedList()
{
    public Node? Head { get; private set; } = null;

    public int Count
    {
        get
        {
            int counter = 0;

            // traverse through the linked list
            for (Node? temp = Head; temp is not null; temp = temp.Next)
            {
                counter += 1;
            }

            return counter;
        }
    }

    public void AddFirst(string data)
    {
        Node newNode = new(data)
        {
            Next = Head
        };

        Head = newNode;
    }

    public void AddLast(string data)
    {
        if (Head is null)
        {
            AddFirst(data);
            return;
        }

        Node temp = Head;

        // traverse to the last node
        while (temp.Next is not null)
        {
            temp = temp.Next;
        }

        // point the next of the last element to the new node
        temp.Next = new Node(data);
    }

    public void RemoveFirst()
    {
        if (Head is null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Head = Head.Next;
    }

    public void RemoveLast()
    {
        // if there is 0 or 1 element in the list, the behaviour is the same as if we were removing the first element
        if (Count <= 1)
        {
            RemoveFirst();
            return;
        }

        Node temp = Head!;
        Node? prev = null;

        // traverse to the last node while storing the node before
        while (temp.Next is not null)
        {
            prev = temp;
            temp = temp.Next;
        }

        // point the Next of the second-to-last node to null
        prev!.Next = null;
    }

    public string GetValue(int index)
    {
        Node? temp = Head;

        if (temp is null || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }

        int counter = 0;

        // traverse to the given index
        while (counter < index)
        {
            counter += 1;
            temp = temp!.Next;
        }

        return temp!.Data;
    }
}