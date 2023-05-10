using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;
        public CoreTests()
        {
            _core = new Core();
        }

        [TestCase("greek",true)]
        [TestCase("british", true)]
        [TestCase("dutch", false)]
        public void checkIfAdded(string type,bool expected)
        {
            Assert.IsTrue(_core.addItem(type) == expected);
        }

        [TestCase("greek", true)]
        [TestCase("british", true)]
        [TestCase("dutch", false)]
        public void checkIfRemoved(string type, bool expected)
        {
            Assert.IsTrue(_core.removeItem(type) == expected);
        }

        [Test]
        public void checkIfCapacityChanged()
        {
            if (_core.changeCapacity(10, "manager"))
            {
                Assert.AreEqual(_core._capacity, 10);
            }
        }

    }
}