using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class BasketTest
{

    [Test]
    public void TestAddBagelToBasket()
    {
        //setup
        Basket basket = new();

        //execute
        basket.AddBagel("someBagel");

        //verify
        Assert.That(basket.GetBagels().Count, Is.EqualTo(1));
        Assert.That(basket.GetBagels()[0], Is.EqualTo("someBagel"));
    }

    [Test]
    public void TestRemoveBagelFromBasket()
    {
        //setup
        Basket basket = new();
        basket.AddBagel("someBagel");

        //execute
        bool wasRemoved = basket.RemoveBagel("someBagel");

        //verify
        Assert.True(wasRemoved);
        Assert.That(basket.GetBagels().Count, Is.EqualTo(0));
    }
}