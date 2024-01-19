namespace csharp_tdd_bobs_bagels.tests;

using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

[TestFixture]
public class BasketTests
{
    private  Basket basket;

    [SetUp]
    public void Setup()
    {

        basket = new Basket(5);
    }

    [Test]
    public void AddBagel_WhenBasketIsNotFull_ReturnsTrue()
    {

        var result = basket.AddBagel("Plain");


        Assert.That(result, Is.True);
    }

    [Test]
    public void AddBagel_WhenBasketIsFull_ReturnsFalse()
    {

        for (int i = 0; i < 5; i++)
        {
            basket.AddBagel($"Bagel{i}");
        }


        var result = basket.AddBagel("ExtraBagel");


        Assert.That(result, Is.False);
    }

    [Test]
    public void RemoveBagel_WhenBagelExists_ReturnsTrue() { 


        basket.AddBagel("Sesame");


        var result = basket.RemoveBagel("Sesame");


        Assert.That(result, Is.True);
    }

    [Test]
    public void RemoveBagel_WhenBagelDoesNotExist_ReturnsFalse()
    {
   
        var result = basket.RemoveBagel("NON");
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsBasketFull_WhenFull_ReturnsTrue()
    {

        for (int i = 0; i < 5; i++)
        {
            basket.AddBagel($"Bagel{i}");
        }


        var result = basket.IsBasketFull();


        Assert.That(result, Is.True);

    }
        [Test]
    public void IsBasketFull_WhenNotFull_ReturnsFalse()
    {

        var result = basket.IsBasketFull();


            Assert.That(result, Is.False);
     }

    [Test]
    public void SetBasketCapacity_ToNewValue_UpdatesCapacity() { 

        basket.SetBasketCapacity(10);
        for (int i = 0; i < 6; i++)
        {
            basket.AddBagel($"Bagel{i}");
        }

        // Assert
        Assert.That(basket.IsBasketFull(), Is.False);
    }
}