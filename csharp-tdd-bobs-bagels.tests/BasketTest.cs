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
            bool isAdded = basket.AddToBasket("new bagel");

            Assert.IsTrue(isAdded);
            Assert.IsTrue(basket._bagels.Any(b => b == "new bagel"));
            Assert.That(basket._bagels.Count, Is.EqualTo(6));
        }

        [Test]
        public void TestAddToBasketFull() {
            basket = new Basket();
            basket._bagels.Add("Plain bagel");
            basket._bagels.Add("Everything Bage");
            basket._bagels.Add("Egg Bagel");
            basket._bagels.Add("French Toast Bagel");
            basket._bagels.Add("Poppy Seed Bagel");
            basket._bagels.Add("Poppy Seed Bagel");
            basket._bagels.Add("Poppy Seed Bagel");
            basket._bagels.Add("Poppy Seed Bagel");
            basket._bagels.Add("Poppy Seed Bagel");
            basket._bagels.Add("Poppy Seed Bagel");

            bool isAdded = basket.AddToBasket("new bagel");

            Assert.IsFalse(isAdded);
            Assert.IsFalse(basket._bagels.Any(b => b == "new bagel"));
            Assert.That(basket._bagels.Count, Is.EqualTo(10));
        }

        [Test]
        public void TestRemoveFromBasket() {
            bool isRemoved = basket.RemoveFromBasket("Egg Bagel");

            Assert.IsTrue(isRemoved);
            Assert.IsFalse(basket._bagels.Contains("Egg Bagel"));
        }

        [Test]
        public void TestChangeBasketSize() {
            basket.ChangeBasketSize(11);
            for (int i = 0; i < 6; i++) {
                basket._bagels.Add("tmp");
            }

            Assert.AreEqual(11, basket._bagels.Count);
            
        }





    }
}