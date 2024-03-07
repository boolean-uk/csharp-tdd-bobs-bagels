using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTests
{
    private Basket _basket;

    [SetUp]
    public void Setup()
    {
        // for each test a new Basket() will be created
        _basket = new Basket();
    }

    [Test]
    public void TestAddBagelToBasket()
    {
        // setup is done in global setup
        // execute the actual function to test
        bool addedBagel = _basket.AddBagelToBasket("Vegan Bagel");
        // Assert test, whether execution is successful ( -> check if results / outputs are ok)
        Assert.That(addedBagel, Is.True);
        Assert.That(_basket, Is.Not.Null);
    }
}