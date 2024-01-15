using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _bagel;

        [SetUp]
        public void Setup()
        {
            _bagel = new Basket();
        }

        [TestCase ("Sweet Bagel", true)]
        [TestCase ("Super Bagel", true)]
        [TestCase ("", false)]
        [TestCase ("Small Bagel", true)]
        public void TestAddBagel(string Type, bool expected) {

            Assert.That(_bagel.AddBagel(Type), Is.EqualTo(expected));
        }

        [Test]
        public void TestAddTwoOfSameType() {
            
            _bagel.AddBagel("Sweet");
            bool actual = _bagel.AddBagel("Sweet");

            Assert.That(actual, Is.EqualTo(false));
        }

        [TestCase ("Sweet Bagel", true)]
        [TestCase ("Super Bagel", true)]
        [TestCase ("", false)]
        [TestCase ("Small Bagel", false)]
        public void TestRemoveBagel(string BagelName, bool expected) {

            _bagel.AddBagel("Sweet Bagel");
            _bagel.AddBagel("Super Bagel");
            Assert.That(_bagel.RemoveBagel(BagelName), Is.EqualTo(expected));
        }

        [Test]
        public void TestIsBasketFull() {
            _bagel.AddBagel("Sweet");
            _bagel.AddBagel("SF");
            _bagel.AddBagel("dsf");
            _bagel.AddBagel("asd");
            _bagel.AddBagel("csa");

            Assert.That(_bagel.IsBasketFull, Is.EqualTo(true));
        }

        [Test]
        public void TestChangeCapacity() {
            Assert.That(_bagel.ChangeCapacity(10), Is.EqualTo(true));
        }
    }
}