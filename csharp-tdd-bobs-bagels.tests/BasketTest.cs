using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;


namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldPutBagelInBasket()
    {
        Basket b = new Basket(3);
        string response = b.BagelInBasket("Creamcheese and blueberry");

        Assert.That(response, Is.EqualTo("Creamcheese and blueberry is in basket"));

    }
    [Test]
    public void ShouldPutBagelInFullBasket()
    {
        Basket b = new Basket(1);
        b.BagelInBasket("Creamcheese and blueberry");
        string response = b.BagelInBasket("Avocado and egg");

        Assert.That(response, Is.EqualTo("Basket is full"));

    }
    [Test]
    public void ShouldRemoveBagelFromBasket()
    {
        Basket b = new Basket(3);
        b.BagelInBasket("Chocolate");
        string response = b.RemoveBagelFromBasket("Chocolate");

        Assert.That(response, Is.EqualTo("Chocolate is removed"));
    }
    [Test]
    public void ShouldNotRemoveNonExistingBagelInBasket()
    {
        Basket b = new Basket(3);
        b.BagelInBasket("Chocolate");
        string response = b.RemoveBagelFromBasket("Mouldy cheese and grape");

        Assert.That(response, Is.EqualTo("There is no Mouldy cheese and grape in your basket ..."));
    }

    [Test]
    public void ShouldChangeBasketSize()
    {
        Basket b = new Basket(2);
        b.BagelInBasket("Chocolate and banana");
        b.BagelInBasket("Strawberry and salmon");
        b.BasketSize = 4;
        b.BagelInBasket("Creamcheese and herbs");
        b.BagelInBasket("Taco");

        Assert.That(b.basket.Count == 4);

    }

}