using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [Test]
    public void AddBagel()
    {
        //Set Up
        Basket basket = new Basket();
        //Execute
        basket.add("Sugar Bagel");
        //verify
        Assert.That(basket.content, Is.Not.Null);
        Assert.That(basket.content[0] == "Sugar Bagel");
    }
    [Test]
    public void RemoveBagel()
    {
        //Set Up
        Basket basket = new Basket();
        //Execute
        basket.add("Sugar Bagel");
        basket.add("Chocolate Bagel");
        basket.remove("Sugar Bagel");
        //verify
        Assert.That(basket.content[0] == "Chocolate Bagel");
    }
    [Test]
    public void BasketLimit()
    {
        //Set Up
        Basket basket = new Basket();
        //Execute
        basket.add("Sugar Bagel");
        basket.add("Chocolate Bagel");
        basket.add("Banana Bagel");
        basket.add("Ham Bagel");
        //verify
        Assert.That(basket.content.Count() == 3);
        Assert.That(basket.errorMessage == "Basket already full");
    }
    [Test]
    public void ChangeBasketLimit()
    {
        //Set Up
        Basket basket = new Basket();
        //Execute
        basket.add("Sugar Bagel");
        basket.add("Chocolate Bagel");
        basket.add("Banana Bagel");
        basket.changeBasketLimit(4);
        basket.add("Ham Bagel");
        basket.changeBasketLimit(2);
        //verify
        Assert.That(basket.content.Count() == 4);
        Assert.That(basket.errorMessage == "Limit cannot be lower than current items in basket");
    }
}