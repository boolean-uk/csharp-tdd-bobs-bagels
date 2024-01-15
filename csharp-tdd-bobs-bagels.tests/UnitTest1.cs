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
        Basket basket = new Basket();
        Bagel bagel = new Bagel("Everything");

        basket.AddToBasket(bagel);
        Assert.That(basket.Bagels.Count != 0);
    }

    [Test]
    public void TestAddIfBasketIsFull() 
    {
        Basket basket = new Basket();
        Bagel bagel1 = new Bagel("Everything");
        Bagel bagel2 = new Bagel("Everything");
        Bagel bagel3 = new Bagel("Everything");
        Bagel bagel4 = new Bagel("Everything");
        Bagel bagel5 = new Bagel("Everything");

        basket.AddToBasket(bagel1);
        basket.AddToBasket(bagel2);
        basket.AddToBasket(bagel3);
        basket.AddToBasket(bagel4);


        var ex = Assert.Throws<Exception>(() => basket.AddToBasket(bagel5));
        Assert.Equals(ex.Message, "No more room in basket");

    }

}