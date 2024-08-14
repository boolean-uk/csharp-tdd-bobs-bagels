namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTests
{
    [SetUp]
    public void Setup()
    {
    }

    //1. As a member of the public, So I can order a bagel before work, I'd like to add a specific type of bagel to my basket.
    [Test]
    public void AddBagelToBasketTest()
    {
        string bagel = "Classic";
        bool expected = true;
        Basket basket = new Basket();

        bool canAddBagel = basket.Add(bagel);
       
        Assert.That(expected == canAddBagel);
    }

    //2. As a member of the public, So I can change my order, I'd like to remove a bagel from my basket.
    [Test]
    public void RemoveBagelFromBasketTest()
    {
        string bagel = "Classic";
        bool expected = true;
        Basket basket = new Basket();

        bool isRemoved = basket.Remove(bagel);

        Assert.That(expected == isRemoved);
    }

    //3. As a member of the public, So that I can not overfill my small bagel basket, I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
    [Test]
    public void BasketIsFullTest()
    {
        string bagel = "Classic";
        string bagel2 = "Salmon";
        string bagel3 = "Avocado";
        bool expected = false;
        Basket basket = new Basket();
        basket.Add(bagel);
        basket.Add(bagel2);

        bool canAddBagel = basket.Add(bagel3);

        Assert.That(expected == canAddBagel);
    }

    //4. As a Bob's Bagel manager, So that I can expand my business, I'd like to change the capacity of baskets.
    [Test]
    public void ChangeCapacityTest()
    {
        int capacity = 5;
        int expected = 5;

        Basket basket = new Basket();

        int newCapacity = basket.ChangeCapacity(capacity);

        Assert.That(expected == newCapacity);
    }

    //5. As a member of the public, So that I can maintain my sanity, I'd like to know if I try to remove an item that doesn't exist in my basket.
    [Test]
    public void BagelIsNotInBasketTest()
    {
        string bagel = "Tomato";
        bool expected = false;
        Basket basket = new Basket();

        bool bagelExist = basket.Remove(bagel);

        Assert.That(expected == bagelExist);

    }
}