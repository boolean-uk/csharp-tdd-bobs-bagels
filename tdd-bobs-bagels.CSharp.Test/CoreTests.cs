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
            bool succes = _core.AddBagel("AvadakedavrO");
                Assert.IsTrue(succes);
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
    }
}