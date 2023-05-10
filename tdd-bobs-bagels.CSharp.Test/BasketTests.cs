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

        [TestCase("Montreal bagel", true)]
        public void TestAddBagel(string bagel, bool expected)
        {
            basket = new Basket();
            Assert.AreEqual(basket.AddBagel(bagel), expected);
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

        [TestCase(1, "Manager", true)]
        [TestCase(1, "Customer", false)]
        public void TestChangeCapacity(int newCapacity, string role, bool expected)
        {
            basket = new Basket();
            bool result = basket.ChangeCapacity(newCapacity, role);
            Assert.AreEqual(result, expected);

            /*basket.AddBagel("Egg bagel");
            basket.AddBagel("Blueberry bagel");
            basket.AddBagel("Montreal bagel");
            basket.AddBagel("Cinnamon raisin bagel");

            Assert.AreEqual(basket.BasketCapacity, 1);
            Assert.IsTrue(basket.IsBasketFull);*/
        }
        
    }
}