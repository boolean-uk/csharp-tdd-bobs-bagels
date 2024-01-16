using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    Basket basket;

    [SetUp]
    public void Setup()
    {
        basket = new Basket();
        basket.AddBagel(Basket.Bagel.Egg);
        basket.AddBagel(Basket.Bagel.Plain);
    }

    [Test]
    public void AddingBagelToBakset()
    {
        string result1 = basket.AddBagel(Basket.Bagel.Everything);
        string result2 = basket.AddBagel(Basket.Bagel.Sesame);

        Assert.That(result1, Is.EqualTo("Bagel added to the basket."));
        Assert.That(result2, Is.EqualTo("Basket is full."));
        Assert.That(basket.GetBasket().Count, Is.EqualTo(3));
    }

    [Test]
    public void RemovingBagelFromBasket()
    {
        basket.AddBagel(Basket.Bagel.Everything);
        
        string result1 = basket.RemoveBagel(Basket.Bagel.Plain);
        string result2 = basket.RemoveBagel(Basket.Bagel.Salt);

        Assert.That(result1, Is.EqualTo("Bagel was removed from the basket."));
        Assert.That(result2, Is.EqualTo("This bagel doesn't exist in basket"));
    }
}