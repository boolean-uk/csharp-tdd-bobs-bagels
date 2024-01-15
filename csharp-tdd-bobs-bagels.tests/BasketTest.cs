using Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class BasketTest
{
    [TestCase("Plain", 2)]
    [TestCase("Sourdough", 3)]
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
    [TestCase("Sourdough")]
    public void RemoveBagelTest(string type)
    {
        //arrange
        Basket basket = new Basket();
        basket.AddBagel(type, 3);

        //act
        basket.RemoveBagel(type);

        //assert
        Assert.IsTrue(basket.Bagels.Count == 0);
        

    }

    [Test]
    public void IsBasketFullTest()
    {
        //arrange
        Basket basket = new Basket();
        basket.AddBagel("PLain", 2);
        basket.AddBagel("Sourdough", 3);
        basket.AddBagel("Egg", 4);

        //act
        bool result = basket.IsBasketFull();

        //assert
        Assert.IsTrue(result);

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