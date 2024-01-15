using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _core;

        [SetUp]
        public void SetUp()
        {
            _core = new Basket();
        }

        [Test]
        public void AddingWorks()
        {
            _core.Add("hi");

            List<string> l1 = _core._basket;

            Assert.That(0, Is.EqualTo(l1.Count));

            _core.Add("A");

            Assert.That(1, Is.EqualTo(l1.Count));


        }
    }
}