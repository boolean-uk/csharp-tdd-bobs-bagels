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
        }

    }
}