namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;
public class Tests
{


    [TestCase("Cheese bagel")]

    public void addBagelTest(string bagel)
    {
        Basket basket = new Basket();
        bool expected = true;
        bool result = basket.addBagel(bagel);

        Assert.That(expected == result);
    }


    [TestCase("Cheese bagel", "Turkey bagel", "Veggie bagel", "Bagel bagel")]

    public void addTooManyBagelsTest(string bagel1, string bagel2, string bagel3, string bagel4)
    {
        Basket basket = new Basket();
        bool expected = false;
        basket.addBagel(bagel1);
        basket.addBagel(bagel2);
        basket.addBagel(bagel3);
        bool result = basket.addBagel(bagel4);

        Assert.That(expected == result);
    }


    [TestCase("Cheese bagel")]

    public void removeBagelTest(string bagel)
    {
        Basket basket = new Basket();
        string expected = "bagel removed";
        basket.addBagel(bagel);
        string result = basket.removeBagel(bagel);

        Assert.That(expected == result);
    }


    [TestCase("Cheese bagel")]
    public void removeNonExistantBagelTest(string bagel)
    {
        Basket basket = new Basket();
        string expected = "bagel does not exist";
        string result = basket.removeBagel(bagel);

        Assert.That(expected == result);
    }

    [TestCase(5)]

    public void changeBasketSizeTest(int size)
    {
        Basket basket = new Basket();
        int expected = 5;
        basket.changeCapacity(5);
        int result = basket.basketMaxSize;

        Assert.That(expected == result);
    }
}