using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private string[] bagels = {"plain bagel", "everything bagel", "chocolate chip bagel"};

        private Basket initialisedBasket()
        {
            Basket basket = new Basket();
            foreach (string bagel in bagels)
            {
                basket.Add(bagel);
            }
            return basket;
        }

        // 1. add a specific type of bagel to my basket
        [Test]
        public void AddABagelToBasketTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.Add("plain bagel"));
        }

        // 2. remove a bagel from my basket
        [Test]
        public void RemoveABagelFromBasketTest()
        {
            Basket basket = initialisedBasket();
            Assert.IsTrue(basket.Remove(bagels[2]));
            Assert.IsTrue(basket.BagelsNum == bagels.Length - 1);
        }

        // 3. know when my basket is full when I try adding an item beyond my basket capacity
        [Test]
        public void Add4BagelsToBasketTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.Add("plain bagel"));
            Assert.IsTrue(basket.Add("everything bagel"));
            Assert.IsTrue(basket.Add("chocolate chip bagel"));
            Assert.IsFalse(basket.Add("salt bagel"));
        }

        // 4. change the capacity of baskets (As a Bob's Bagels manager)
        [Test]
        public void ChangeCapacityOfBasketTest()
        {
            Basket basket = initialisedBasket();
            
            basket.ChangeCapacity(4, true);

            Assert.IsTrue(basket.Capacity == 4);
            Assert.IsTrue(basket.Add("salt bagel"));
        }

    }
}