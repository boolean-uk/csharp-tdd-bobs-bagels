using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddingBagelToBakset()
    {
        Basket basket = new Basket();

        string result1 = basket.AddBagel(Basket.Bagel.Egg);
        string result2 = basket.AddBagel(Basket.Bagel.Plain);
        string result3 = basket.AddBagel(Basket.Bagel.Everything);
        string result4 = basket.AddBagel(Basket.Bagel.Sesame);

        Assert.That(result1, Is.EqualTo("Bagel added to the basket."));
        Assert.That(result2, Is.EqualTo("Bagel added to the basket."));
        Assert.That(result3, Is.EqualTo("Bagel added to the basket."));
        Assert.That(result4, Is.EqualTo("Basket is full."));
        Assert.That(basket.GetBasket().Count, Is.EqualTo(3));
    }
}