using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;
public class BasketTests
{
    [Test]
    public void addBagelTest()
    {
        //arrange
        Basket basket = new Basket();

        //act
        string bagel = "Ali";
        basket.add(bagel);

        //assert
        Assert.IsTrue(basket.Bagels.Contains(bagel));
    }
    [Test]
    public void removeBagelTest()
    {
        //arrange
        Basket basket = new Basket();

        //act
        string bagel2 = "haider";
        basket.remove(bagel2);

        //assert
        Assert.IsFalse(basket.Bagels.Contains(bagel2));

    }

    [Test]

    public void basketIsFull()
    {
        //arrange
        Basket basket = new Basket();

        //act
        basket.add("Butter");
        basket.add("Cheese");
        basket.add("Pan");

        bool result = basket.basketisFull();


        //assert
        Assert.IsTrue(result);
    }
    [Test]
    public void changecapasity()
    {
        //arrange
        Basket basket = new Basket();

        //act
        basket.add("Butter");
        basket.add("Cheese");
        basket.add("Pan");
        basket.add("Bagel");
        basket.add("Bagel2");

        int newcapasity = 5;
        int expected = 5;

        //assert
        Assert.That(newcapasity, Is.EqualTo(expected));

    }
    [Test]
    public void removeNotExistingItem()
    {
        //arrange
        Basket basket = new Basket();

        
        //act
        
        basket.add("bagel1");

        basket.remove("bagel2");

        bool result = basket.Bagels.Contains("bagel2");

        //assert
        Assert.That(!result, Is.True); 
       



    }
}