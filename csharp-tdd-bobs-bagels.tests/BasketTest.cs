using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests
{
    [TestFixture]
    internal class BasketTest
    {

        [Test]
        public void add() 
        {
            // arrange 
            Basket core = new Basket();
            string bagel = "cream bagel";

            // act
            core.basket.Add(bagel);
            string result = core.basket.first();
            int length = core.basket.count();

            // assert
            Assert.AreEqual(bagel, result);
            Assert.IsTrue(length == 1);            
        }
    }
}
