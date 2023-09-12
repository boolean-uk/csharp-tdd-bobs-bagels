using tdd_bobs_bagels.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class CoreTests
    {
        private Core _core;

        [SetUp]
        public void Setup()
        {
            _core = new Core();
        }

        [Test]
        public void CanAddBagel()
        {
            bool success = _core.AddBagel("AvadakedavrO");
                Assert.IsTrue(success);
        }

        [Test]
        public void CanRemoveBagel()
        {
            _core.AddBagel("AvadakedavrO");
            bool removed = _core.RemoveBagel("AvadakedavrO");
            Assert.IsTrue(removed);
        }

        [Test]
        public void BasketIsFull()
        {
            _core.SetCapacity(5);
            _core.AddBagel("Harry");
            _core.AddBagel("potter");
            _core.AddBagel("Lord");
            _core.AddBagel("Voldemort");
            _core.AddBagel("Dementor");
            bool isFull = _core.IsFull();
            Assert.IsTrue(isFull);
        }
        [Test]
        public void CantAddWhenBasketIsFull()
        {
            _core.SetCapacity(2);
            _core.AddBagel("AvadakedavrO");
            _core.AddBagel("Bellatric Lestrange");
            bool success = _core.AddBagel("dumbledore");
            Assert.IsFalse(success);
        }

        [Test]
        public void CannotRemoveABagelThatDoesntExist()
        {
            bool removed = _core.RemoveBagel("Cloak of invisibility");
            Assert.IsFalse(removed);
        }

        [Test]
        public void CannotUpdateAboveCapacity()
        {
            _core.SetCapacity(4);
            _core.AddBagel("Ron Weasley");
            _core.AddBagel("Luna Lovegood");
            _core.AddBagel("Neville Longbottom");
            _core.AddBagel("Hedwig");
            bool added = _core.AddBagel("professor Severus Snape");
            Assert.IsFalse(added);
        }

        [Test]
        public void DefaultCapacityFivecheck()
        {
            for (int i = 0; i < 5; i++)
            {
                _core.AddBagel("Dobby" + i);
            }
            bool isFull = _core.IsFull();
            Assert.IsTrue(isFull);
        }

        [Test]
        public void RemovingBagelFromEmptyBasketShouldReturnFalse()
        {
            bool removed = _core.RemoveBagel("Lilly Potter");
            Assert.IsFalse(removed);
        }
    }
}