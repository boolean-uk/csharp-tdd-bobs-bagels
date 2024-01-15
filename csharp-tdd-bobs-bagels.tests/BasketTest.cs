using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

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
}