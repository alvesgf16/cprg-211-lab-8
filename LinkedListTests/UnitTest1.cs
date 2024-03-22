using CustomLinkedList;

namespace LinkedListTests;

public class Tests
{
    [Test]
    public void AddFirst_EmptyList_AddsNodeToBeginning()
    {
        // Arrange
        LinkedList list = new();

        // Act
        list.AddFirst("Joe Blow");

        // Assert
        Assert.That(list.Count, Is.EqualTo(1));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Blow"));
    }

    [Test]
    public void AddFirst_NonEmptyList_AddsNodeToBeginning()
    {
        // Arrange
        LinkedList list = new();
        list.AddFirst("Joe Schmoe");

        // Act
        list.AddFirst("Joe Blow");

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Blow"));
    }

    [Test]
    public void AddLast_EmptyList_AddsNodeToEnd()
    {
        // Arrange
        LinkedList list = new LinkedList();

        // Act
        list.AddLast("Joe Blow");

        // Assert
        Assert.That(list.Count, Is.EqualTo(1));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Blow"));
        Assert.IsNull(list.Head.Next);
    }

    [Test]
    public void AddLast_NonEmptyList_AddsNodeToEnd()
    {
        // Arrange
        LinkedList list = new LinkedList();
        list.AddLast("Joe Schmoe");

        // Act
        list.AddLast("Joe Blow");

        // Assert
        Assert.That(list.Count, Is.EqualTo(2));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Schmoe"));
        Assert.That(list.Head.Next!.Data, Is.EqualTo("Joe Blow"));
        Assert.IsNull(list.Head.Next.Next);
    }

    [Test]
    public void AddLast_MultipleAdds_AddsNodesInCorrectOrder()
    {
        // Arrange
        LinkedList list = new LinkedList();
        list.AddLast("Joe Schmoe");
        list.AddLast("Joe Blow");

        // Act
        list.AddLast("John Smith");

        // Assert
        Assert.That(list.Count, Is.EqualTo(3));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Schmoe"));
        Assert.That(list.Head.Next!.Data, Is.EqualTo("Joe Blow"));
        Assert.That(list.Head.Next.Next!.Data, Is.EqualTo("John Smith"));
        Assert.IsNull(list.Head.Next.Next.Next);
    }

    [Test]
    public void RemoveFirst_EmptyList_WritesToConsole()
    {
        // Arrange
        LinkedList list = new();
        StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        list.RemoveFirst();

        // Assert
        Assert.That(sw.ToString(), Is.EqualTo("List is empty\r\n"));
    }

    [Test]
    public void RemoveFirst_SingleNodeList_RemovesNode()
    {
        // Arrange
        LinkedList list = new();
        list.AddFirst("Joe Blow");

        // Act
        list.RemoveFirst();

        // Assert
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void RemoveFirst_MultipleNodesList_RemovesFirstNode()
    {
        // Arrange
        LinkedList list = new();
        list.AddLast("Joe Blow");
        list.AddLast("Joe Schmoe");

        // Act
        list.RemoveFirst();

        // Assert
        Assert.That(list.Count, Is.EqualTo(1));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Schmoe"));
    }

    [Test]
    public void RemoveLast_EmptyList_WritesToConsole()
    {
        // Arrange
        LinkedList list = new();
        StringWriter sw = new();
        Console.SetOut(sw);

        // Act
        list.RemoveLast();

        // Assert
        Assert.That(sw.ToString(), Is.EqualTo("List is empty\r\n"));
    }

    [Test]
    public void RemoveLast_SingleNodeList_RemovesNode()
    {
        // Arrange
        LinkedList list = new();
        list.AddLast("Joe Blow");

        // Act
        list.RemoveLast();

        // Assert
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void RemoveLast_MultipleNodesList_RemovesLastNode()
    {
        // Arrange
        LinkedList list = new();
        list.AddLast("Joe Blow");
        list.AddLast("Joe Schmoe");

        // Act
        list.RemoveLast();

        // Assert
        Assert.That(list.Count, Is.EqualTo(1));
        Assert.That(list.Head!.Data, Is.EqualTo("Joe Blow"));
    }
}