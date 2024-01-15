using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    private Basket basket;

    [SetUp]
    public void Setup()
    {
        // Initialize a new Basket with a capacity of 3 before each test
        basket = new Basket(3);
    }

    [Test]
    public void TestAddBagel()
    {
        Basket basket = new Basket(5);
        basket.AddBagel("Plain");
        Assert.AreEqual(basket.Bagels, new List<string> { "Plain" });
    }

    [Test]
    public void TestRemoveBagel()
    {
        Basket basket = new Basket(5);
        basket.AddBagel("Plain");
        basket.AddBagel("Potet");
        basket.RemoveBagel("Plain");
        basket.RemoveBagel("Potet");
        Assert.AreEqual(basket.Bagels, new List<string>());

    }

    [Test]
    public void TestIsFull()
    {
        Basket basket = new Basket(2);
        basket.AddBagel("Plain");
        basket.AddBagel("Whole Wheat");
        Assert.IsTrue(basket.IsFull());
    }


    [Test]
    public void TestChangeCapaciytOfBasket()
    {

        Basket basket = new Basket(5);
        basket.ChangeCapacity(10);
        Assert.AreEqual(basket.Capacity, 10);
    }

    [Test]
    public void TestRemoveItemDoesNotExist()
    {
        {
            Basket basket = new Basket(5);
            Assert.Throws<InvalidOperationException>(() => basket.RemoveBagel("Blueberry"));
        }
    }



}