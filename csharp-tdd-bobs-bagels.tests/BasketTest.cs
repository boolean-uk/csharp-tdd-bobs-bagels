namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTests
{
    /*
    [SetUp]
    public void Setup()
    {
    }
    */

    [Test]
    public void AddTest()
    {
        //arrange

        Basket basket = new Basket();
        bool expected = true;

        //act
        bool result = basket.Add("Ham and cheese bagel");

        //assert
        Assert.That(expected == result);
    }

    [Test]
    public void RemoveTest()
    {
        //arrange
        Basket basket = new Basket();
        basket.Add("Salmon Bagel");
        
        bool expected = true;

        //act
        bool result = basket.Remove("Salmon Bagel");

        //assert
        Assert.That(expected == result);
    }

    [Test]
    public void AddToFulLBasketTest()
    {
        //arrange
        Basket basket = new Basket();

        basket.Add("Salmon Bagel");
        basket.Add("Cream cheese Bagel");
        basket.Add("Avocado Bagel");
        basket.Add("Ham and Cheese Bagel");
        basket.Add("Bacon Bagel");


        bool expected = false;

        //act
        bool result = basket.Add("Everything Bagel");

        //assert
        Assert.That(expected == result);
    }

    [Test]
    public void ChangeCapacityTest()
    {
        //arrange
        Basket basket = new Basket();


        int expected = 10;

        //act
        int result = basket.ChangeCapacity(10);

        //assert
        Assert.That(expected == result);
    }

    [Test]
    public void RemoveNonExistingItemTest()
    {
        //arrange
        Basket basket = new Basket();
        basket.Add("Cream Cheese Bagel");
        basket.Add("Avocado Bagel");

        bool expected = false;

        //act
        bool result= basket.Remove("Shrimp and mayo Bagel");

        //assert
        Assert.That(expected == result);
    }


}