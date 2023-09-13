using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;

        [SetUp]
        public void Setup()
        {
            _core = new Core(1); 
        }

        [Test]
        public void AddBagelToBasket()
        {
            _core.AddBagel("Plain");

            Assert.AreEqual(1, _core.GetBagelCount());
        }

        [Test]
        public void RemoveBagelFromBasket()
        {
            _core.AddBagel("Sesame");
            bool removed = _core.RemoveBagel("Sesame");

            Assert.IsTrue(removed);
            Assert.AreEqual(0, _core.GetBagelCount());
        }

        [Test]
        public void BasketIsFull()
        {
            _core.AddBagel("Cinnamon Raisin");
            _core.AddBagel("Everything");

            bool isFull = _core.IsFull();
            Assert.IsTrue(isFull);
        }

        [Test]
        public void ChangeBasketCapacity()
            {
             int initialCapacity = _core.SetCapacity();
             _core.AddBagel("Blueberry");
             _core.AddBagel("Asiago");
             _core.AddBagel("Onion");
             _core.RemoveBagel("Asiago");
             _core.AddBagel("Cheddar");

             int newCapacity = _core.SetCapacity();

             Assert.AreEqual(initialCapacity, newCapacity);
        }

        [Test]
        public void RemoveNonExistingBagel()
        {
            bool removed = _core.RemoveBagel("Poppy Seed");

            Assert.IsFalse(removed);
            Assert.AreEqual(0, _core.GetBagelCount());
        }
    }
}