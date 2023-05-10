using NUnit.Framework;
using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class BasketTests
    {
        public Basket basket;
        public BasketTests()
        {
        }

        [TestCase("Montreal bagel")]
        public void TestAddBagel(string bagel)
        {
            basket = new Basket();
            Assert.AreEqual(basket.AddBagel(bagel), true);
        }

        [TestCase("Egg bagel")]
        public void TestRemoveBagel(string bagel)
        {
            basket = new Basket();
            basket.AddBagel(bagel);

            bool result = basket.RemoveBagel(bagel);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestBasketCapacity()
        {
            basket = new Basket();
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Blueberry bagel");
            basket.AddBagel("Montreal bagel");
            basket.AddBagel("Cinnamon raisin bagel");

            Assert.AreEqual(basket.bagels.Count, basket.BasketCapacity);
            Assert.IsTrue(basket.IsBasketFull);
        }

        [TestCase("Egg bagel", false)]
        public void TestRemoveBagelIfItDoesntExist(string bagel, bool expected)
        {
            basket = new Basket();
            bool result = basket.RemoveBagel(bagel);
            Assert.AreEqual(result, expected);

        }

        [TestCase(1)]
        public void TestChangeCapacity(int newCapacity)
        {
            basket = new Basket();
            basket.ChangeCapacity(newCapacity);
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Blueberry bagel");
            basket.AddBagel("Montreal bagel");
            basket.AddBagel("Cinnamon raisin bagel");

            Assert.AreEqual(basket.bagels.Count, basket.BasketCapacity);
            Assert.IsTrue(basket.IsBasketFull);
        }
        
    }
}