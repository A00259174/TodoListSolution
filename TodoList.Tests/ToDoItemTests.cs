// Test 1 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[Test]
public void TestToDoItemConstructor()
{
    // Arrange
    int expectedId = 1;
    DateTime expectedDueDate = new DateTime(2023, 1, 1);

    // Act
    var item = new ToDoItem(expectedId, expectedDueDate);

    // Assert 
    Assert.AreEqual(expectedId, item.Id);
    Assert.AreEqual(expectedDueDate, item.DueDate);
}

// Test 2
[Test]
public void CompletedDateIsNullByDefault()
{
    // Arrange
    var item = new ToDoItem(1, DateTime.Now);

    // Assert
    Assert.IsNull(item.CompletedDate);
}

// Test 3
[Test]
public void CanCompleteToDoItem()
{
    // Arrange 
    var item = new ToDoItem(1, DateTime.Now);

    // Act
    item.Complete();

    // Assert
    Assert.IsNotNull(item.CompletedDate);
}

// Test 4
[Test]
public void CanUncompleteToDoItem()
{
    // Arrange
    var item = new ToDoItem(1, DateTime.Now);
    item.Complete();

    // Act
    item.Uncomplete();

    // Assert
    Assert.IsNull(item.CompletedDate);
}