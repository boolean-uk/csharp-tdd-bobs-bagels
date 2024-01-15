using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace csharp_tdd_bobs_bagels.tests
{
    [TestFixture]
    internal class BasketTest
    {
        [Test]
        public void AddTest()
        {
            Basket basket = new Basket();



            Assert.Pass();
        }

        [Test]
        public void RemoveTest()
        {
            Basket basket = new Basket();

            Assert.Pass();
        }

        [Test]
        public void SetCapacityTest()
        {
            Basket basket = new Basket();

            Assert.Pass();
        }
    }
}
