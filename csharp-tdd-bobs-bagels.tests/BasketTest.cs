using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    Basket _basket = new Basket();

    [SetUp]
    public void Setup()
    {
        _basket = new Basket();
    }

    [Test]
    [TestCase("Plain Bagel")]
    [TestCase("Everything Bagel")]
    [TestCase("Cinnamon Raisin Bagel")]
    public void AddBagelToBasketTest(string input)
    {
        // Arrange
        string bagel = input;

        // Act
        bool res = _basket.AddBagelToBasket(bagel);

        // Assert
        Assert.That(res, Is.True);
    }

    [Test]
    [TestCase("Cinnamon Raisin Bagel", true)]
    [TestCase("Plain Bagel", true)]
    [TestCase("Eggs and bacon", false)]
    [TestCase("Everything Bagel", true)]
    public void RemoveBagelFromBasketTest(string input, bool expected) 
    {
        // Arrange
        string bagel1 = "Plain Bagel";
        string bagel2 = "Everything Bagel";
        string bagel3 = "Cinnamon Raisin Bagel";
        _basket.AddBagelToBasket(bagel1);
        _basket.AddBagelToBasket(bagel2);
        _basket.AddBagelToBasket(bagel3);

        // Act
        bool res = _basket.RemoveBagelFromBasket(input);

        // Assert
        Assert.That(res, Is.EqualTo(expected));
    }

    [Test]
    public void HasRoomTest() 
    {
        // Arrange
        TextWriter originalConsoleOut = Console.Out;
        StringWriter sw = new StringWriter();
        Console.SetOut(sw); // Have sw catch console output
        string bagel1 = "Plain Bagel";
        string bagel2 = "Everything Bagel";
        string bagel3 = "Cinnamon Raisin Bagel";
        string bagel4 = "Sesame Bagel";
        string bagel5 = "Blueberry Bagel";
        string bagel6 = "Onion Bagel";
        string bagel7 = "Poppy Seed Bagel";
        string basketFullMsg = "You can't get more bagels because the basket is full!";

        // Act
        bool res1 = _basket.AddBagelToBasket(bagel1);
        bool res2 = _basket.AddBagelToBasket(bagel2);
        bool res3 = _basket.AddBagelToBasket(bagel3);
        bool res4 = _basket.AddBagelToBasket(bagel4);
        bool res5 = _basket.AddBagelToBasket(bagel5);
        bool res6 = _basket.AddBagelToBasket(bagel6);
        bool res7 = _basket.AddBagelToBasket(bagel7);
        string[] consoleOut = sw.ToString().Split("\n");


        // Assert
        Assert.That(res1, Is.True);
        Assert.That(res2, Is.True);
        Assert.That(res3, Is.True);    
        Assert.That(res4, Is.True);
        Assert.That(res5, Is.True);
        // Capacity is 5 by default, rest should be false
        Assert.That(res6, Is.False);
        Assert.That(res7, Is.False);

        // Check that both the overfull basket additions display. (Basicly n+1 test)
        Assert.That(consoleOut[0], Is.EqualTo(basketFullMsg));
        Assert.That(consoleOut[1], Is.EqualTo(basketFullMsg));

        // Restore normal console operation
        Console.SetOut(originalConsoleOut);

    }

    [Test]
    [TestCase(6)]
    [TestCase(8)]
    [TestCase(999)]
    [TestCase(3)] // This would remove items, but that is necessary so that the manager can control the baskets.
    public void SetBasketSizeTest(int newSize) 
    {
        // Arrange
        string bagel1 = "Plain Bagel";
        string bagel2 = "Everything Bagel";
        string bagel3 = "Cinnamon Raisin Bagel";
        string bagel4 = "Sesame Bagel";
        string bagel5 = "Blueberry Bagel";
        _basket.AddBagelToBasket(bagel1);
        _basket.AddBagelToBasket(bagel2);
        _basket.AddBagelToBasket(bagel3);
        _basket.AddBagelToBasket(bagel4);
        _basket.AddBagelToBasket(bagel5);

        // Assert
        int res = _basket.SetBasketSize(newSize);

        // Act
        Assert.That(newSize < 5 ? newSize : 5, Is.EqualTo(res));

    }
}