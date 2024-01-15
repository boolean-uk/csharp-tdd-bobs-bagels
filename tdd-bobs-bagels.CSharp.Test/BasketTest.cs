using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class BasketTests
    {
        private Basket basket;
        
        [SetUp]
        public void Setup()
        {
            basket = new Basket();
        }

        [Test]
        public void TestChangeCapacity()
        {
            Assert.That(basket.ChangeCapacity(10), Is.True);
        }

        [Test]
        public void TestAddItem()
        {
            Assert.That(basket.AddItem(1), Is.True);
        }

        [Test]
        public void TestRemoveItem()
        {
            basket.AddItem(1);
            Assert.That(basket.RemoveItem(1), Is.True);
        }

        [Test]
        public void TestChangeCapacityToZero()
        {
            Assert.That(basket.ChangeCapacity(0), Is.False);
        }

        [Test]
        public void TestAddItemToFullBasket()
        {
            basket.ChangeCapacity(1);
            basket.AddItem(1);
            Assert.That(basket.AddItem(1), Is.False);
        }

        [Test]
        public void TestRemoveItemFromEmptyBasket()
        {
            Assert.That(basket.RemoveItem(1), Is.False);
        }

    }
}