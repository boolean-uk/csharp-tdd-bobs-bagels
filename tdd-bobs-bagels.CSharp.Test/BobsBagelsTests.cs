using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BobsBagelsTests
    {
        //private BobsBagels _basket;
        //public BobsBagelsTests()
        //{
        //    _basket = new BobsBagels();
        //}
        [Test]
        public void InitialTest()
        {
            Assert.Pass();
        }
        [Test]
        public void TestAddBagel()
        {
            //I'd like to add a specific type of bagel to my basket
            BobsBagels _basket = new BobsBagels();
            _basket.AddProduct("Cheese bagel");
            Assert.IsTrue(_basket.basket.Contains("Cheese bagel"));
        }
        [Test]
        public void TestRemoveBagel()
        {
            //I'd like to remove a bagel from my basket
            BobsBagels _basket = new BobsBagels();
            _basket.AddProduct("Cheese bagel");
            _basket.AddProduct("Salmon bagel");
            _basket.RemoveProduct("Salmon bagel");
            Assert.IsFalse(_basket.basket.Contains("Salmon bagel"));
            Assert.AreEqual(_basket.RemoveProduct("Cheese bagel"), "Cheese bagel removed");

        }
        [Test]
        public void TestRemoveNonExistingBagel()
        {
            //I'd like to know if I try to remove an item that doesn't exist in my basket.
            BobsBagels _basket = new BobsBagels();
            _basket.AddProduct("Cheese bagel");
            _basket.RemoveProduct("Cheese bagel");
            Assert.AreEqual(_basket.RemoveProduct("Cheese bagel"), "Item not found");
        }

        [Test]
        public void TestBasketCapacityReached()
        {
            //I'd like to know when my basket is full when I try adding an item beyond my basket capacity
            BobsBagels _basket = new BobsBagels();
            _basket.AddProduct("Cheese bagel");
            _basket.AddProduct("Salmon bagel");
            _basket.AddProduct("Bacon bagel");
            _basket.AddProduct("Nutella bagel");
            Assert.AreEqual(_basket.basket.Count, _basket.MaxCapacityBasket);
        }

        [TestCase(5)]
        public void TestChangeBasketCapacity(int count)
        {
            //I’d like to change the capacity of baskets
            BobsBagels _basket = new BobsBagels();
            _basket.AddProduct("Cheese bagel");
            _basket.AddProduct("Salmon bagel");
            _basket.AddProduct("Bacon bagel");
            _basket.AddProduct("Nutella bagel");
            _basket.ChangeBasketCapacity(count);
            Assert.AreEqual(_basket.MaxCapacityBasket, 5);
        }

    }
}