using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;

namespace csharp_tdd_bobs_bagels.tests;
public class BasketTests
{
    [Test]
    public void AddedBagelToBasket()
    {
        // 1. Setup
        Basket basket = new Basket();

        // 2. Execute
        string bagelName = "Cream-cheese bagel";
        basket.Add(bagelName);

        // 3. Verify
        Assert.IsTrue(basket.Bagels.Contains(bagelName));
    }
   
    [Test]
    public void RemovedBagelFromBasket()
    {
        // 1. Setup
        Basket basket = new Basket();

        // 2. Execute
        string bagelName = "Avocado smoked salmon bagel";
        basket.Add(bagelName);
        basket.Remove(bagelName);

        // 3. Verify
        Assert.IsTrue(!basket.Bagels.Contains(bagelName));
    }   

    [Test]
    public void BasketIsFullWhenTryingToAddBagel()
    {
        // 1. Setup
        Basket basket = new Basket();

        // 2. Execute
        string bagelName = "Cheddar jalapeno bagel";
        basket.BasketCapacity = 0;
        string result = basket.Add(bagelName);
        
        // 3. Verify
        Assert.IsTrue(!basket.Bagels.Contains(bagelName) & result == $"There is no space for {bagelName}");
    }

    [Test]
    public void SetBasketCapacity()
    {
        // 1. Setup
        Basket basket = new Basket();

        // 2. Execute
        int newBasketCapacity = 100; 
        basket.BasketCapacity = newBasketCapacity;

        // 3. Verify
        Assert.IsTrue(basket.BasketCapacity == newBasketCapacity);
    }

    [Test]
    public void RemoveBagelThatDoesntExist()
    {
        // 1. Setup
        Basket basket = new Basket();

        // 2. Execute
        string bagelName = "Nutella bagel";
        basket.Add(bagelName);
        basket.Remove(bagelName);
        string result = basket.Remove(bagelName);

        // 3. Verify
        Assert.IsTrue(!basket.Bagels.Contains(bagelName) & result == $"{bagelName} does not exist.");
    }
}