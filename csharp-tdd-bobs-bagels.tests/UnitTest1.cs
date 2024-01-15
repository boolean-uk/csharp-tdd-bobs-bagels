using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void testAdd()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        basket.Add("bread");
        basket.Add(bagel2);
        List<string> testResult = new List<string>() { 
            bagel1, bagel2
        };


        //Assert
        Assert.AreEqual(testResult, basket._basket);

    }

    [Test]
    public void testRemove()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        string bagel3 = "Moji";
        basket.Add(bagel1);
        basket.Add(bagel2);
        basket.Add(bagel3);

        basket.Remove(bagel1);
        List<string> testResult = new List<string>() {
            bagel2, bagel3
        };


        //Assert
        Assert.AreEqual(testResult, basket._basket);

    }

    [Test]
    public void testCheckBasket1()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        string bagel3 = "Moji";
        basket.Add(bagel1);
        basket.Add(bagel2);
        basket.Add(bagel3);
        int capacity = basket.getCapacity;
        bool status = basket.checkBasketFull();

        
        //Assert
        Assert.IsTrue(status == true && capacity == basket._basket.Count);

    }

    [Test]
    public void testCheckBasket2()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        string bagel3 = "Moji";
        basket.Add(bagel1);
        basket.Add(bagel2);
       
        int capacity = basket.getCapacity;
        bool status = basket.checkBasketFull();


        //Assert
        Assert.IsTrue(status == false);

    }

    [Test]
    public void testNewCapacity()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        string bagel3 = "Moji";
        basket.Add(bagel1);
        basket.Add(bagel2);
        basket.Add(bagel3);
        int newCapacity = 5;
        basket.NewCapacity(newCapacity);


        //Assert
        Assert.IsTrue(basket.getCapacity == newCapacity);

    }

    [Test]
    public void testNewCapacity2()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        string bagel3 = "Moji";
        basket.Add(bagel1);
        basket.Add(bagel2);
        basket.Add(bagel3);
        int newCapacity = 5;
        basket.NewCapacity(newCapacity);


        //Assert
        Assert.IsTrue(basket.getCapacity != 3);

    }

    [Test]
    public void testCheckBasket()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        string bagel3 = "Moji";
        string bagel4 = "Brownie";
        basket.Add(bagel1);
        basket.Add(bagel2);
        basket.Add(bagel3);
        int newCapacity = 5;
        basket.NewCapacity(newCapacity);
        bool sanityCheck1 = CheckBasket(bagel1);
        bool sanityCheck2 = CheckBasket(bagel4);


        //Assert
        Assert.IsTrue(sanityCheck1 == true && sanityCheck2 == false);

    }


}