using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests {

    [TestFixture]
    public class BasketTest {
        
        private Basket? basket;

        [SetUp]
        public void SetUp() {
            basket = new Basket();
            basket._bagels.Add("Plain bagel");
            basket._bagels.Add("Everything Bage");
            basket._bagels.Add("Egg Bagel");
            basket._bagels.Add("French Toast Bagel");
            basket._bagels.Add("Poppy Seed Bagel");
        }

        [Test]
        public void TestAddToBasket() {

        }

        [Test]
        public void TestAddToBasketFull() {
            
        }

        [Test]
        public void RemoveFromBasket() {

        }

        [Test]
        public void ChangeBasketSize() {

        }





    }
}