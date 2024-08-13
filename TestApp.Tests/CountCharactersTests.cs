using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa", "aaa", "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 6"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa", "abc", "aabbcc" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 5");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 3");
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);
         
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa", "a!bc", "a!abb!cc!" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 5");
        sb.AppendLine("! -> 4");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 3");
        
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithUpperCaseAndNumberCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa", "a!bc", "a!abb!cc!", "ABC123", "CBA321", "BCA231", "BCA321" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 5");
        sb.AppendLine("! -> 4");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 3");
        sb.AppendLine("A -> 4");
        sb.AppendLine("B -> 4");
        sb.AppendLine("C -> 4");
        sb.AppendLine("1 -> 4");
        sb.AppendLine("2 -> 4");
        sb.AppendLine("3 -> 4");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
