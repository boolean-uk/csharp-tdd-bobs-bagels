using NUnit.Framework;
using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class BasketTests
    {
        //private Basket _basket;
        public Basket basket;
        public BasketTests()
        {
           //_basket = new Basket();
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
            basket.AddBagel("sda");
            basket.AddBagel("eqweq");
            basket.AddBagel("xzczx");
            bool result = basket.AddBagel("dfghdfg");
            bool expected = false;

            Assert.AreEqual(result, false);
        }

        [TestCase("Egg bagel", false)]
        public void TestRemoveBagelIfItDoesntExist(string bagel, bool expected)
        {
            basket = new Basket();
            bool result = basket.RemoveBagel(bagel);
            Assert.AreEqual(result, expected);

        }
    }
}