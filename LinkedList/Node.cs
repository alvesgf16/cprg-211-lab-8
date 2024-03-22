namespace LinkedListNS;

public class Node(string data)
{
    public Node? Next { get; set; } = null;
    public string Data { get; set; } = data;
}
