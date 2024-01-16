using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using tdd_bobs_bagels.CSharp.Main.Classes;

namespace csharp_tdd_bobs_bagels.tests
{
    [TestFixture]
    internal class BasketTest
    {
        private Basket _basket;
        private Bagel _bagel;

        [SetUp]
        public void SetUp()
        {
            _basket = new Basket();
            _bagel = new Bagel("Test");
            _basket.Add(_bagel);
        }


        [Test]
        public void AddTest()
        {
            Assert.That(_basket.Bagels.First(), Is.EqualTo(_bagel));
        }

        [Test]
        public void AddToFullCartTest() 
        { 
            _basket.Add(_bagel);
            _basket.Add(_bagel);
            Assert.That(_basket.Add(_bagel), Is.EqualTo("Basket is full"));
        }

        [Test]
        public void RemoveTest()
        {
            _basket.Remove("Test");
            Assert.That(_basket.Bagels, Is.EqualTo(new Basket().Bagels));
        }

        [Test]
        public void RemoveNonexistantTest()
        {
            Assert.That(_basket.Remove("test1"), Is.EqualTo("Could not find given bagel type"));
        }

        [Test]
        public void SetCapacityTest()
        {
            _basket.SetCapacity(1);

            Assert.That(_basket.Capacity, Is.EqualTo(1));
        }
    }
}
