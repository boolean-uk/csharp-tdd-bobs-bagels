using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {

        Basket _basket = new();

        [Test]
        public void OrderBagelTest()
        {
            _basket.Order("Frosted Bagel");
            _basket.Order("Plain Bagel");
            Assert.That(_basket.Orders.Contains("Frosted Bagel"), Is.True);
            Assert.That(_basket.Orders.Contains("Plain Bagel"), Is.True);
        }

        [Test]
        public void RemoveBagelTest()
        {
            _basket.Order("Plain Bagel");
            Assert.That(_basket.Remove("Plain Bagel"), Is.True);
        }

        [Test]
        public void ChangeCapacityTest()
        {
            _basket.Capacity(10);
            Assert.That(_basket.Capacity, Is.EqualTo(10));
        }
    }
}
