namespace LinkedListNS;

/// <summary>
/// Represents a node in a linked list data structure.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="Node"/> class with the specified data.
/// </remarks>
/// <param name="data">The data to be stored in the node.</param>
public class Node(string data)
{
    /// <summary>
    /// The data stored in the node.
    /// </summary>
    public string Data { get; set; } = data;

    /// <summary>
    /// A reference to the next node in the linked list.
    /// </summary>
    public Node? Next { get; set; } = null;
}
