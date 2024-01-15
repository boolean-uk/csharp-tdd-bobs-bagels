using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class BasketTests
    {
        private Basket _core;
        public BasketTests()
        {
            _core = new Basket();
            _core.AddBagel("Cream");
            _core.AddBagel("Cheese");
            _core.AddBagel("Dressing");
        }

        [Test]
        public void AddedBagel()
        {
            bool haveAdded = _core.basket.Count() > 0;
            Assert.IsTrue(haveAdded);
        }

        [TestCase("Peanut", true)]
        [TestCase("", false)]
        [TestCase("Cream", false)]
        public void AddingMore(string bagelType, bool expected)
        {
            bool haveAdded = _core.AddBagel(bagelType);
            Assert.That(expected, Is.EqualTo(haveAdded));
        }

        [Test]
        public void RemovedBagel()
        {
            int beforeRem = _core.basket.Count();
            _core.RemoveBagel("Cream");
            int afterRem = _core.basket.Count();
            Assert.That(beforeRem, Is.GreaterThan(afterRem));
        }

        [TestCase("Cheese", true)]
        [TestCase("", false)]
        [TestCase("Cheese", false)]
        public void RemovedMore(string bagelType, bool expected)
        {
            bool haveAdded = _core.RemoveBagel(bagelType);
            Assert.That(expected, Is.EqualTo(haveAdded));
        }

        [Test]
        public void IsBasketFull()
        {
            bool full = _core.BasketFull();
            Assert.That(true, Is.EqualTo(full));
        }

        [Test]
        public void BasketFuller()
        {
            _core.AddBagel("Lime");
            bool full = _core.BasketFull();
            Assert.That(false, Is.EqualTo(full));
        }

        [Test]
        public void IncreasedCapacity()
        {
            _core.IncreaseCapacity(_core.capacity + 3);
            bool full = _core.AddBagel("Peanuts");
            Assert.That(true, Is.EqualTo(full));
        }

        [Test]
        public void TooMuchCapacity()
        {
            int oldCapacity = _core.capacity;
            _core.IncreaseCapacity(-1);
            int newCapacity = _core.capacity;
            Assert.That(oldCapacity, Is.EqualTo(newCapacity));
        }

        [TestCase("Cream", true)]
        [TestCase("Jam", false)]
        [TestCase("Dressing", true)]
        public void ItemDoesExist(string bagelType, bool expected)
        {
            bool removed = _core.RemoveBagel(bagelType);
            Assert.That(expected, Is.EqualTo(removed));
        }
    }
}