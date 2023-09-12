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
            Assert.IsTrue(basket.add("plain bagel"));
        }
    }
}