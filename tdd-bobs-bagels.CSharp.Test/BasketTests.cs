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

        //input "cream cheese bagel" ==> "cream cheese bagel added to your basket"
        [Test]
        public void AddFistTest()
        {
            string result = _basket.Add("cream cheese bagel");
            Assert.AreEqual(result, "cream cheese bagel added to your basket");
        }

        //input "grana padano cheese bagel" ==> "grana padano cheese bagel is not on our menu"
        [Test]
        public void AddSecondTest()
        {
            string result = _basket.Add("grana padano cheese bagel");
            Assert.AreEqual(result, "grana padano cheese bagel is not on our menu");
        }

        //input "cream cheese bagel", "vegan bagel" ==> "Could not add vegan bagel, Your basket is full"
        [Test]
        public void AddThirdTest()
        {
            _basket.UpdateCapacity(1);
            _basket.Add("cream cheese cheese bagel");
            string result = _basket.Add("vegan bagel");
            Assert.AreEqual(result, "Could not add vegan bagel, Your basket is full");
        }

        //input "cream cheese bagel" ==> "cream cheese bagel removed from your basket"
        [Test]
        public void RemoveFirstTest()
        {
            _basket.Add("cream cheese bagel");
            string result = _basket.Remove("cream cheese bagel");

            Assert.AreEqual(result, "cream cheese bagel removed from your basket");
        }

        //input "cream cheese bagel" ==> "Cannot remove from basket since vegan bagel was not in your basket"
        [Test]
        public void RemoveSecondTest()
        {
            _basket.Add("cream cheese bagel");
            string result = _basket.Remove("vegan bagel");

            Assert.AreEqual(result, "Cannot remove from basket since vegan bagel was not in your basket");
        }

        //input 5 ==> "New basket capacity is 5"
        [Test]
        public void UpdateCapacityFirstTest()
        {
            string result = _basket.UpdateCapacity(5);

            Assert.AreEqual(result, "New basket capacity is 5");
        }
    }
}