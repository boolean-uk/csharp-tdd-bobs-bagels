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

}