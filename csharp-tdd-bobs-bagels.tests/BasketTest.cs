using Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class BasketTest
{
    [TestCase("Plain", 2)]
    public void AddBagelTest(string type, int 2)
    {

        //arrange
        Basket basket = new Basket();
        basket.Bagels.Add("Plain", 2);

        //act
        basket.AddBagel(type, 2);

        //assert
        Assert.IsTrue(basket.Bagels.Count > 0);

    }


    [TestCase("Plain")]
    public void RemoveBagelTest(string type)
    {


    }

    [Test]
    public void IsBasketFull()
    {

    }

    [Test]
    public void ChangeBasketCapacity()
    {

    }
    
}