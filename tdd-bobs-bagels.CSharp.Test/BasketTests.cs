using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _basket;
        public BasketTests()
        {
            _basket = new Basket(6);
            _basket.addBagel("poppy seed"); //1
            _basket.addBagel("cream cheese"); //2
            _basket.addBagel("smoked ham"); //3
            _basket.addBagel("bacon"); //4
            _basket.addBagel("standard"); //5
            _basket.addBagel("everyting"); //6
            _basket.addBagel("chicken hickory"); //7 should not be added
        }
        [Test]
        public void addBagelTest()
        {
            Assert.IsTrue(_basket.content.Contains("poppy seed"));
            Assert.IsTrue(_basket.content.Contains("cream cheese"));
            Assert.IsFalse(_basket.content.Contains("sesame seed"));
        }
        [Test]
        public void doesNotExceedTest()
        {
            Assert.IsFalse(_basket.content.Contains("chicken hickory"));
        }
        [Test]
        public void removeBagelTest()
        {
            _basket.removeBagel("bacon");
            Assert.IsTrue(_basket.content.Contains("poppy seed"));
            Assert.IsFalse(_basket.content.Contains("bacon"));
        }
        [Test]
        public void changeCapacityTest()
        {
            Assert.AreEqual(7, _basket.changeCapacity(1));
        }
    }
}