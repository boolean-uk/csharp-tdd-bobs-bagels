using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTest
{
  

    [Test] 
    public void testOrderBagel()
    {
        //SetUp
        Basket basket = new Basket();
        basket.Capacity = 10;
        string bagel = "bagel";

        //Execute
        basket.orderBagel(bagel);

        //Verify
        Assert.IsTrue(basket.Items.Contains(bagel));
    }

    [Test]
    public void testRemoveBagel()
    {
        //SetUp
        Basket basket = new Basket();
        basket.Capacity = 10;
        string bagel = "avo-bagel";

        //Execute
        basket.orderBagel(bagel);
        basket.removeBagel(bagel);


        //Verify
        Assert.IsFalse(basket.Items.Contains(bagel));


    }

    [Test]
    public void testIsFull()
    {
        //SetUp
        Basket basket = new Basket();
        basket.Capacity = 0;

        //Execute
        

        //Verify
        Assert.IsTrue(basket.isFull());
    }

    [Test]
    public void testNotFull()
    {
        //SetUp
        Basket basket = new Basket();


        //Execute
        basket.Capacity = 10;

        //Verify
        Assert.IsFalse(basket.isFull());
    }

    [Test]
    public void testChangeCapacity()
    {
        //SetUp
        Basket basket = new Basket();
        

        //Execute
        int result = basket.changeCapacity(6);

        //Verify
        Assert.That(basket.Capacity == result);
    }


 
}