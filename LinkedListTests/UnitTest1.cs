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
}