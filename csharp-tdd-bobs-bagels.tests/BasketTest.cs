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
        Assert.That(basket, Is.Not.Null);
    }
}