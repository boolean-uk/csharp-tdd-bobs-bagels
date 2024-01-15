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
            _basket = new Basket();
        }
        [SetUp]
        public void SetUp()
        {
            _basket = new Basket();
        }

        [Test]
        public void AddTest()
        {
            bool result = _basket.AddBagel("donut");
            Assert.IsTrue(result);
            Assert.IsTrue(_basket.Bagels.Contains("donut"));
        }

        [Test]
        public void AddFullTest()
        {
            _basket._capacity = 1;
            _basket.AddBagel("blueberry");
            bool result = _basket.AddBagel("sourdough");
            Assert.IsFalse(result);
            Assert.IsFalse(_basket.Bagels.Contains("sourdough"));
            Assert.IsTrue(_basket.Bagels.Contains("blueberry"));
        }
        [Test]
        public void RemoveTest()
        {
            _basket.AddBagel("cinnamon");
            _basket.AddBagel("poppy seed");
            _basket.AddBagel("cheese");
            bool result = _basket.RemoveBagel("poppy seed");
            Assert.IsTrue(result);
            Assert.IsFalse(_basket.Bagels.Contains("poppy seed"));
            Assert.IsTrue(_basket.Bagels.Contains("cheese"));
        }
        [Test]
        public void RemoveEmptyTest()
        {
            _basket.AddBagel("cinnamon");
            _basket.AddBagel("poppy seed");
            _basket.AddBagel("cheese");
            bool result = _basket.RemoveBagel("chocolate chip");
            Assert.IsFalse(result);
            Assert.IsFalse(_basket.Bagels.Contains("chocolate chip"));
            Assert.IsTrue(_basket.Bagels.Contains("cheese"));
        }
    }
}