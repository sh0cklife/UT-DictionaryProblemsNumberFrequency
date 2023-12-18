using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int input = 0;
        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int input = 1;
        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        // Assert
        Dictionary<int, int> expected = new Dictionary<int, int>
        {
            { 1, 1 }
        };
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = 35353532;
        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        // Assert
        Dictionary<int, int> expected = new Dictionary<int, int>
        {
            { 3, 4 },
            { 5, 3 },
            { 2, 1 }
        };
        Assert.That(expected, Is.EqualTo(result));

    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = -2323233;
        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(input);
        // Assert
        Dictionary<int, int> expected = new Dictionary<int, int>
        {
            { 2, 3 },
            { 3, 4 }
        };
        Assert.That(expected, Is.EqualTo(result));
    }
}
