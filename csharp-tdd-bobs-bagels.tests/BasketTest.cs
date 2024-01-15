using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTest
{
    [Test]
    public void Add()
    {
        Basket core = new Basket();
        core.basketLimit = 2;

        string result1 = core.addBagel("cinnamon");
        string resultEmptyString = core.addBagel("");
        core.addBagel("bread");
        string resultFull = core.addBagel("apple");

        Assert.AreEqual(result1, "added to Basket");
        Assert.AreEqual(resultEmptyString, "no input detected");
        Assert.AreEqual(resultFull, "cart is full");
    }
    
    [Test]
    public void Remove()
    {
        Basket core = new Basket();
        core.basketLimit = 2;

        core.addBagel("cinnamon");

        string result1 = core.removeBagel("cinnamon");
        string resultEmptyString = core.removeBagel("");
        string resultDoesntExist = core.removeBagel("apple");

        Assert.AreEqual(result1, "removed from Basket");
        Assert.AreEqual(resultEmptyString, "no input detected");
        Assert.AreEqual(resultDoesntExist, "bagel doesnt exist in basket");
    }
    [Test]
    public void editLimit()
    {
        Basket core = new Basket();
        core.basketLimit = 2;

        bool resultTrue = core.changeLimit(5);
        bool resultFalse = core.changeLimit(-5);

        Assert.IsTrue(resultTrue);
        Assert.IsFalse(resultFalse);
    }
}