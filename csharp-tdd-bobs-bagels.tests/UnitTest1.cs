using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAdd()
    {
        Basket basket = new Basket(4);
        Bagel bagel = new Bagel("Everything");

        basket.AddToBasket(bagel);
        Assert.That(basket.Bagels.Count != 0);
    }

    [Test]
    public void TestAddIfBasketIsFull() 
    {
        Basket basket = new Basket(4);
        Bagel bagel1 = new Bagel("Everything");
        Bagel bagel2 = new Bagel("Everything");
        Bagel bagel3 = new Bagel("Everything");
        Bagel bagel4 = new Bagel("Everything");
        Bagel bagel5 = new Bagel("Everything");

        basket.AddToBasket(bagel1);
        basket.AddToBasket(bagel2);
        basket.AddToBasket(bagel3);
        basket.AddToBasket(bagel4);


        var ex = Assert.Throws<ArgumentException>(() => basket.AddToBasket(bagel5));
        Assert.That(ex.Message == "No more room in basket");

    }

    [Test]

    public void TestRemove()
    {
        Basket basket = new Basket(4);

        Bagel bagel1 = new Bagel("Everything");
        Bagel bagel2 = new Bagel("Sesame");
        Bagel bagel3 = new Bagel("Lox");

        basket.AddToBasket(bagel1);
        basket.AddToBasket(bagel2);
        basket.AddToBasket(bagel3);

        basket.RemoveFromBasket(bagel3);

        Assert.That(basket.Bagels.Count, Is.EqualTo(2));
    }

}