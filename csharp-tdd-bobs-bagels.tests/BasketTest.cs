using Objects.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main.Objects;
using tdd_bobs_bagels.CSharp.Main.Objects.Core;

namespace csharp_tdd_bobs_bagels.tests
{
    public class BasketTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(2)]
        [TestCase(20)]
        [TestCase(50)]
        [TestCase(-5)]
        [TestCase(0)]
        [TestCase(10000)]
        public void ManagerResizeTest(int newSize)
        {
            Manager manager = new Manager();
            Basket basket = new Basket();

            Assert.IsTrue(manager.AlterSize(basket, newSize));
        }

        [Test]
        public void ProductTest()
        {
            Bagel bagel = new Bagel();
            Product product1 = new Bagel();

            Assert.IsTrue(bagel.GetPrice() >= 0);
            Assert.IsTrue(product1.GetPrice() >= 0);
            
        }


        [Test]
        public void AddProductTest()
        {
            Bagel bagel = new Bagel();
            Product product1 = new Bagel();
            Basket basket = new Basket();
            Bagel fakeBagel = null;

            Assert.IsTrue(basket.AddProduct(bagel));
            Assert.IsTrue(basket.AddProduct(product1));
            Assert.IsFalse(basket.AddProduct(fakeBagel));
        }

        [Test]
        public void RemoveProductTest()
        {
            Bagel bagel = new Bagel();
            Product product1 = new Bagel();
            Basket basket = new Basket();
            Bagel fakeBagel = null;

            basket.AddProduct(bagel);
            basket.AddProduct(fakeBagel);

            Assert.IsTrue(basket.RemoveProduct(bagel));
            Assert.IsFalse(basket.RemoveProduct(product1));
            Assert.IsFalse(basket.RemoveProduct(fakeBagel));
        }
    }
}
