using NUnit.Framework.Interfaces;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Core core = new Core();
        Assert.Pass();
    }

    [Test]
    public void AddNotFull()
    {
        Core.Basket basket = new Core.Basket();

        string bagel = "Blueberry";

        basket.Add(bagel);

        Assert.IsTrue(basket.Bagels.Contains(bagel), "Bagel should be in basket");
    }

    [Test]
    public void AddFull()
    {
        Core.Basket basket = new Core.Basket();

        string bagel = "Blueberry";

        basket.Add("Bagel 1");
        basket.Add("Bagel 2");
        basket.Add("Bagel 3");
        basket.Add("Bagel 4");
        basket.Add("Bagel 5");
        basket.Add("Bagel 6");

        string expectedOutput = "Basket is full\r\n";

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            basket.Add(bagel);

            string actualOutput = sw.ToString();
            Assert.That(actualOutput, Is.EqualTo(expectedOutput), "The console output should match the expected output.");

            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }

        Assert.IsFalse(basket.Bagels.Contains(bagel), "Bagel should not be in basket");
    }

    [Test]
    public void RemoveExistingBagel()
    {
        Core.Basket basket = new Core.Basket();

        string bagel = "Blueberry";

        basket.Add(bagel);
        basket.Remove(bagel);

        Assert.IsFalse(basket.Bagels.Contains(bagel), "Bagel should not be in basket");
    }

    [Test]
    public void RemoveNonexistingBagel()
    {
        Core.Basket basket = new Core.Basket();

        string bagel = "Blueberry";

        string expectedOutput = $"{bagel} was not found in basket\r\n";

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            basket.Remove(bagel);

            string actualOutput = sw.ToString();
            Assert.That(actualOutput, Is.EqualTo(expectedOutput), "The console output should match the expected output.");

            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }

        Assert.IsFalse(basket.Bagels.Contains(bagel), "Bagel should not be in basket");
    }

    [Test]
    public void Changecapacity()
    {
        Core.Basket basket = new Core.Basket();

        int newCapacity = 10;

        basket.ChangeCapacity(newCapacity);

        Assert.That(basket.Capacity, Is.EqualTo(newCapacity), "Capacity should have been updated.");
    }
}