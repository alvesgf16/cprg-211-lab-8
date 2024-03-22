namespace LinkedListNS;

public class LinkedList()
{
    public Node? Head { get; private set; } = null;

    public int Count
    {
        get
        {
            Node? temp = Head;
            int counter = 0;

            // traverse through the linked list
            while (temp is not null)
            {
                counter += 1;
                temp = temp.Next;
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
        Node newNode = new(data);

        if (Head is null)
        {
            Head = newNode;
            return;
        }

        Node temp = Head;

        // traverse to the last node
        while (temp.Next is not null)
        {
            temp = temp.Next;
        }

        // point the next of the last element to the new node
        temp.Next = newNode;
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
        Node? temp = Head;
        Node? prev = null;

        if (temp is null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        // traverse to the last node while storing the node before
        while (temp.Next is not null)
        {
            prev = temp;
            temp = temp.Next;
        }

        // this handles a single node list
        if (prev is null)
        {
            Head = null;
            return;
        }

        // point the Next of the second-to-last node to null
        prev.Next = null;
    }

    public string GetValue(int index)
    {
        Node? temp = Head;

        if (temp is null)
        {
            throw new IndexOutOfRangeException();
        }

        if (index >= Count)
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