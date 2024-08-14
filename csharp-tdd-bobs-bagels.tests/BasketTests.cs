using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Cheese Bagel")]
    public void AddBagelTest(string bagel)
    {
        Basket basket = new Basket();
        bool expected = true;

        bool result = basket.addBagel(bagel);

        Assert.That(expected == result);
    }

    [TestCase("Cheese Bagel", "Ham Bagel", "Salad Bagel", "Turkey Bagel")]
    public void AddBagelTest(string bagel1, string bagel2, string bagel3, string bagel4)
    {
        Basket basket = new Basket();
        bool expected = false;

        basket.addBagel(bagel1);
        basket.addBagel(bagel2);
        basket.addBagel(bagel3);

        bool result = basket.addBagel(bagel4);

        Assert.That(expected == result);
    }

    [TestCase("Cheese Bagel", "Ham Bagel")]
    public void RemoveBagelTest(string bagel1, string bagel2)
    {
        Basket basket = new Basket();

        basket.addBagel(bagel1);

        string expected1 = $"{bagel1} removed";
        string expected2 = $"There is no {bagel2} in the basket";

        string result1 = basket.removeBagel(bagel1);
        string result2 = basket.removeBagel(bagel2);

        Assert.That(expected1 == result1);
        Assert.That(expected2 == result2);
    }

    [TestCase(4)]
    public void ChangeBasketCapacityTest(int capacity)
    {
        Basket basket = new Basket();

        int expected = 4;

        basket.changeBasketCapacity(capacity);

        Assert.That(expected == basket.maxBasketSize);
    }
}