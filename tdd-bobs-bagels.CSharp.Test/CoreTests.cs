using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddABagelToBasketTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.Add("plain bagel"));
        }

        [Test]
        public void Add4BagelsToBasketTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.Add("plain bagel"));
            Assert.IsTrue(basket.Add("everything bagel"));
            Assert.IsTrue(basket.Add("chocolate chip bagel"));
            Assert.IsFalse(basket.Add("salt bagel"));
        }
    }
}