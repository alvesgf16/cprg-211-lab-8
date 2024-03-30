namespace LinkedListNS;

/// <summary>
/// Represents a singly linked list data structure.
/// </summary>
public class LinkedList
{
    /// <summary>
    /// A reference to the first node in the linked list.
    /// </summary>
    public Node? Head { get; private set; } = null;

    /// <summary>
    /// The number of nodes contained in the linked list.
    /// </summary>
    public int Count { get; private set; } = 0;

    /// <summary>
    /// Adds a new node with the specified data to the beginning of the linked list.
    /// </summary>
    /// <param name="data">The data to be stored in the new node.</param>
    public void AddFirst(string data)
    {
        Node newNode = new(data)
        {
            // point the Next of the new node to the current Head
            Next = Head
        };

        // point the Head to the new node
        Head = newNode;
        Count += 1;
    }

    /// <summary>
    /// Adds a new node with the specified data to the end of the linked list.
    /// </summary>
    /// <param name="data">The data to be stored in the new node.</param>
    public void AddLast(string data)
    {
        if (IsEmpty())
        {
            AddFirst(data);
            return;
        }

        int lastIndex = Count - 1;
        Node lastNode = GetNodeAt(lastIndex);

        // point the next of the current last element to the new node
        lastNode.Next = new Node(data);
        Count += 1;
    }

    /// <summary>
    /// Removes the first node from the linked list.
    /// </summary>
    public void RemoveFirst()
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty");
            return;
        }

        // point the Head to the Next of the first node
        Head = Head!.Next;
        Count -= 1;
    }

    /// <summary>
    /// Removes the last node from the linked list.
    /// </summary>
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

    /// <summary>
    /// Gets the data stored in the node at the specified index in the linked list.
    /// </summary>
    /// <param name="index">The zero-based index of the node whose data to retrieve.</param>
    /// <returns>The data stored in the node at the specified index.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown when the specified index is out of range.</exception>
    public string GetValue(int index)
    {
        if (IsOutOfRange(index))
        {
            throw new IndexOutOfRangeException();
        }

        Node current = GetNodeAt(index);

        return current.Data;
    }

    /// <summary>
    /// Checks whether the linked list is empty.
    /// </summary>
    /// <returns>True if the linked list is empty; otherwise, false.</returns>
    private bool IsEmpty() => Count == 0;

    /// <summary>
    /// Checks whether the specified index is out of range in the linked list.
    /// </summary>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is out of range; otherwise, false.</returns>
    private bool IsOutOfRange(int index) => index < 0 || index >= Count;

    /// <summary>
    /// Retrieves the node at the specified index in the linked list.
    /// </summary>
    /// <param name="index">The zero-based index of the node to retrieve.</param>
    /// <returns>The node at the specified index.</returns>
    private Node GetNodeAt(int index)
    {
        Node current = Head!;

        for (; index > 0; index -= 1)
        {
            current = current.Next!;
        }

        return current;
    }
}