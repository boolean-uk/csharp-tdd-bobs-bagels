using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTests
{
    private Basket _basket;
    private List<string> _bagelsInBasket;

    [SetUp]
    public void Setup()
    {
        // for each test a new Basket() will be created
        _basket = new Basket(5);
        _bagelsInBasket = new List<string>();
        // bagel is added to each test.
        _basket.AddBagelToBasket("Spelt Bagel");
        _basket.AddBagelToBasket("Sesame salmon Bagel");
        _basket.AddBagelToBasket("Whole wheat Bagel");
        _basket.AddBagelToBasket("Avocado Bagel");
        _basket.AddBagelToBasket("Hummus Bagel");
    }

    [Test]
    public void TestAddBagelToBasket()
    {
        // setup is done in global setup
        // execute the actual function to test
        bool addedBagel = _basket.AddBagelToBasket("Vegan Bagel");
        //int itemsInBasket = _bagelsInBasket.Count;  
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(addedBagel, Is.True);
        Assert.That(_basket, Is.Not.Null);
        // try to see that basket contains 2 items now
       
    }

    [Test]  
    public void TestChangeOrder()
    {
        // setup is done in global setup
        // execute the actual function to test
        bool changeOrder = _basket.ChangeOrder("Spelt Bagel");
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(changeOrder, Is.True);
    }

    [Test]
    public void TestFullBasket()
    {
        // execute the actual function to test
        bool maxBagelsInBasket = _basket.FullBasket(5);
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(maxBagelsInBasket, Is.True);    
    }

    [Test]
    public void TestSetNewBasketCapacity()
    {
        // execute the actual function to test
        bool setNewCapacity = _basket.SetBasketCapacity(20);
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(setNewCapacity, Is.True);
    }

    /*

    [Test]
    public void TestDeletedBagelThatNotExcists()
    {
        // execute the actual function to test

        // Assert test, whether execution is successful ( -> check if results / outputs are ok)

    }
    */

}