namespace CustomLinkedList;

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
            while (temp != null)
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
}