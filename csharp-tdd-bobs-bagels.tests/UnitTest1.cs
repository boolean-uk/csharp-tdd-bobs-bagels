using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    [Test]
    public void AddItemTest()
    {
        BagelBasket b = new BagelBasket( );

        b.add("poppy seed");

        Assert.AreEqual(b.bagles.Count, 1);
    }

    [Test]
    public void RemoveItemTest()
    {
        BagelBasket b = new BagelBasket();

        b.add("poppy seed");

        b.remove("poppy seed");

        Assert.AreEqual(b.bagles.Count, 0);
    }

    [Test]
    public void AddToBasketWithRoomTest()
    {
        BagelBasket b = new BagelBasket();

        bool added = b.add("poppy seed");

        Assert.That(added);

    }

    [Test]
    public void AddToFullBasketTest()
    {
        BagelBasket b = new BagelBasket();
        b.add("cream cheese");

        bool added = b.add("poppy seed");

        Assert.That(!added);

    }

    [Test]
    public void ChangeCapacityTest()
    {
        BagelBasket b = new BagelBasket();

        b.Capacity = 10;

        Assert.AreEqual(b.Capacity, 10);

    }

    [Test]
    public void RemoveItemInBasketTest()
    {
        BagelBasket b = new BagelBasket();
        b.add("cream cheese");

        bool removed = b.remove("cream cheese");

        Assert.That(removed);

    }

    [Test]
    public void RemoveItemNotInBasketTest()
    {
        BagelBasket b = new BagelBasket();
        b.add("poppy seed");

        bool removed = b.remove("cream cheese");

        Assert.That(!removed);

    }
}