using Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class BasketTest
{
    [TestCase("Plain", 2)]
    public void AddBagelTest(string type, int price)
    {

        //arrange
        Basket basket = new Basket();

        //act
        basket.AddBagel(type, price);

        //assert
        Assert.IsTrue(basket.Bagels.Count > 0);

    }


    [TestCase("Plain")]
    public void RemoveBagelTest(string type)
    {
        //arrange

        //act

        //assert
        Assert.Fail();

    }

    [Test]
    public void IsBasketFull()
    {
        //arrange

        //act

        //assert
        Assert.Fail();
    }

    [Test]
    public void ChangeBasketCapacity()
    {
        //arrange

        //act

        //assert
        Assert.Fail();
    }
    
}