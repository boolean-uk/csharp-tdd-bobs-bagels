using tdd_bobs_bagels.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tdd_bobs_bagels.tests
{
    internal class BasketTest
    {
        private Basket _basket;
        public BasketTest()
        {
            _basket = new Basket();
        }

        [Test]
        public void Test1()
        {
            //  Arrange - set up test values


            //  Act - use the fucntion we want to test

            //  Assert - check the results
            Assert.That(false==true);
        }
    }
}
