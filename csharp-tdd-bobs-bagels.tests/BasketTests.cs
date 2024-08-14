using bobsBagels.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelAmount()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");

        Assert.IsTrue(basket.Bagels.Count() == 2);
    }

    [Test]
    public void AddBagelContains()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");

        Assert.IsTrue(basket.Bagels.Contains("Cream cheese"));
    }

    [Test]
    public void RemoveBagel()
    {
        Basket basket = new Basket();
        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");

        basket.RemoveBagel("Salmon");

        Assert.IsTrue(basket.Bagels.Count() == 1);
    }

    [Test]
    public void GetBasketSize()
    {
        Basket basket = new Basket();

        Assert.IsTrue(basket.BasketSize == 2);
    }

    [Test]
    public void AddBagelWhenFull()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");
        basket.AddBagel("Cheese");

        Assert.IsTrue(basket.BasketSize == 2);
    }

    [Test]
    public void BasketIsFull()
    {
        Basket basket = new Basket();

        basket.AddBagel("Cream cheese");
        basket.AddBagel("Salmon");
        basket.AddBagel("Cheese");

        Assert.IsTrue(basket.BasketIsFull);
    }

    [Test]
    public void ChangeBasketSize()
    {
        Basket basket = new Basket();

        basket.BasketSize = 5;

        Assert.IsTrue(basket.BasketSize == 5);
    }

    [Test]
    public void RemoveNonexistent()
    {
        Basket basket = new Basket();

        Assert.IsTrue(basket.RemoveBagel("Ham and cheese") == false);
    }
}