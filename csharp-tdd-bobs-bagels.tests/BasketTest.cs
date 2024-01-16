using System.Runtime.CompilerServices;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests
{
    [TestFixture]
    public class BasketTest
    {
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            //arrange
            Basket basket = new Basket();
            //act
            basket.AddBagel("Plain bagel");
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Poppy Seed bagel");
            //assert
            Assert.AreEqual(3, basket.myBasket.Count);
            Assert.IsTrue(basket.myBasket.Count <= basket.BasketSize);
        }
        [Test]
        public void RemoveTest()
        {
            //arrange
            Basket basket = new Basket();
            basket.AddBagel("Plain bagel");
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Poppy Seed bagel");
            //act
            basket.RemoveBagel("Egg bagel");
            basket.RemoveBagel("Poppy Seed bagel");
            //assert
            Assert.AreEqual(1, basket.myBasket.Count);
            Assert.IsTrue(basket.myBasket.Count <= basket.BasketSize);
        }
        [Test]
        public void FullBasketTest()
        {
            //arrange
            Basket basket = new Basket();
            basket.AddBagel("Plain bagel");
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Poppy Seed bagel");
            basket.AddBagel("Blueberry bagel");
            basket.AddBagel("Sourdough bagel");
            //act
            bool isFull = basket.FullBasket(basket.myBasket);
            //assert
            Assert.IsTrue(isFull);
        }
        [Test]
        public void BasketCapacityTest()
        {
            //arrange
            Basket basket = new Basket();
            basket.AddBagel("Plain bagel");
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Poppy Seed bagel");
            basket.AddBagel("Blueberry bagel");
            basket.AddBagel("Sourdough bagel");
            //act
            basket.BasketCapacity(6);
            basket.AddBagel("Whole Weat bagel");
            //assert
            Assert.AreEqual(6, basket.myBasket.Count);
            Assert.IsTrue(basket.myBasket.Count <= basket.BasketSize);
        }
        [Test]
        public void SchrodingersBagelTest()
        {
            //arrange
            Basket basket = new Basket();
            basket.AddBagel("Plain bagel");
            basket.AddBagel("Egg bagel");
            basket.AddBagel("Poppy Seed bagel");
            basket.AddBagel("Blueberry bagel");
            basket.AddBagel("Sourdough bagel");
            //act
            bool exists1 = basket.SchrodingersBagel("Egg bagel");
            bool exists2 = basket.SchrodingersBagel("Pumpernickel bagel");
            //assert
            Assert.IsTrue(exists1);
            Assert.IsFalse(exists2);
        }
    }
}