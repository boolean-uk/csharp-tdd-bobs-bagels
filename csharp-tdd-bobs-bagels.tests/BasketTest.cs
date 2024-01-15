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
        basket.addBagel("someBagel");

        //verify
        Assert.AreEqual(basket.getBagels().Count, 1);
    }
}