using NUnit.Framework;
using System.Reflection.Emit;
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

        //input "cream cheese" ==> "cream cheese bagel added to your basket"
        [Test]
        public void AddFistTest()
        {
            string result = _basket.Add("cream cheese");
            Assert.AreEqual("cream cheese bagel added to your basket", result);
        }

        //input "grana padano cheese" ==> "grana padano cheese bagel is not a bagel type on our menu"
        [Test]
        public void AddSecondTest()
        {
            string result = _basket.Add("grana padano cheese");
            Assert.AreEqual(result, "grana padano cheese is not a bagel type on our menu");
        }

        //input "cream cheese", "vegan" ==> "Your basket is full"
        [Test]
        public void AddThirdTest()
        {
            _basket.UpdateCapacity(1);
            _basket.Add("cream cheese");
            string result = _basket.Add("vegan");
            Assert.AreEqual("Your basket is full", result);
        }

        //input "cream cheese" ==> "cream cheese bagel removed from your basket"
        [Test]
        public void RemoveFirstTest()
        {
            _basket.Add("cream cheese");
            string result = _basket.Remove("cream cheese");

            Assert.AreEqual("cream cheese bagel removed from your basket", result);
        }

        //input "cream cheese" ==> "Cannot remove from basket since vegan bagel was not in your basket"
        [Test]
        public void RemoveSecondTest()
        {
            _basket.Add("cream cheese");
            string result = _basket.Remove("vegan");

            Assert.AreEqual("Cannot remove from basket since that bagel was not in your basket", result);
        }

        //input 5 ==> "New basket capacity is 5"
        [Test]
        public void UpdateCapacityFirstTest()
        {
            string result = _basket.UpdateCapacity(5);

            Assert.AreEqual("New basket capacity is 5", result);
        }
        //input 5 ==> "New basket capacity is 5"
        [Test]
        public void UpdateCapacitySecondTest()
        {
            string result = _basket.UpdateCapacity(-3);

            Assert.AreEqual("basket capacity cannot be smaller than 1", result);
        }
    }
}