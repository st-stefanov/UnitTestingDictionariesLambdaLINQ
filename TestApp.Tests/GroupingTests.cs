﻿using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Globalization;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new();
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 2, 1, 3, 4};
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4\r\nOdd numbers: 1, 3"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 6, 2, 8, 4 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 6, 2, 8, 4"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 1, 5, 3, 7 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 5, 3, 7"));
        
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { -1, -2, -3, -4 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: -1, -3\r\nEven numbers: -2, -4"));
    }
}
