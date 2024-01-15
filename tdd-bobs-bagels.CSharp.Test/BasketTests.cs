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

        [Test]
        public void RemovedBagel()
        {
            int beforeRem = _core.basket.Count();
            _core.RemoveBagel("Cream");
            int afterRem = _core.basket.Count();
            Assert.That(beforeRem, Is.GreaterThan(afterRem));
        }

        [Test]
        public void IsBasketFull()
        {
            bool full = _core.AddBagel("Peanuts");
            Assert.That(false, Is.EqualTo(full));
        }

        [Test]
        public void IncreasedCapacity()
        {
            _core.capacity = 6;
            bool full = _core.AddBagel("Peanuts");
            Assert.That(true, Is.EqualTo(full));
        }

        [TestCase("Cream", true)]
        [TestCase("Jam", false)]
        [TestCase("Dressing", true)]
        public void RemovedBagel(string bagelType, bool expected)
        {
            bool removed = _core.RemoveBagel(bagelType);
            Assert.That(expected, Is.EqualTo(removed));
        }
    }
}