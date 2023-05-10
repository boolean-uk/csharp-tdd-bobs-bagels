using NUnit.Framework;
using System.IO;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class CoreTests
    {
        private Core _core;
        public CoreTests()
        {
            _core = new Core();
        }

        [Test]
        public void AddBagelToBasket()
        {
            // I'd like to add a specific type of bagel to my basket.

            // arrange
            string bagel = "Bagel with salmon";

            // act
            _core.addBagel(bagel);

            // assert
            Assert.AreEqual(bagel, _core.basket.ElementAt(0));
        }

        [Test]
        public void RemoveBagelFromBasket()
        {
            // I'd like to remove a bagel from my basket.

            // arrange
            string bagel = "Bagel with salmon";
            _core.addBagel(bagel);

            // act
            _core.removeBagel(bagel);

            // assert
            Assert.IsFalse(_core.basket.Contains(bagel));
        }

        [Test]
        public void CheckIfBasketFull()
        {
            // I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

            // arrange
            string bagel = "Bagel with salmon";
            string bagel1 = "Bagel with chicken";
            string bagel2 = "Bagel with beef";
            string bagel3 = "Bagel with prawns";

            // act
            _core.addBagel(bagel);
            _core.addBagel(bagel1);
            _core.addBagel(bagel2);
            _core.addBagel(bagel3);

            // assert
            Assert.AreEqual(_core.basket.Count, _core.basketMax);
        }

        [TestCase(2)]
        public void ChangeBasketCapacity(int max)
        {
            // I’d like to change the capacity of baskets.

            // arrange
            string bagel = "Bagel with salmon";
            string bagel1 = "Bagel with chicken";
            string bagel2 = "Bagel with beef";
            string bagel3 = "Bagel with prawns";

            _core.addBagel(bagel);
            _core.addBagel(bagel1);
            _core.addBagel(bagel2);
            _core.addBagel(bagel3);

            // act
            _core.changeCapacity(max);

            // assert
            Assert.AreEqual(_core.basket.Count, max);
        }

        [Test]
        public void BagelNotInBasket()
        {
            // I'd like to know if I try to remove an item that doesn't exist in my basket.

            // arrange
            string bagel = "Bagel with salmon";
            string bagel1 = "Bagel with chicken";
            _core.addBagel(bagel);

            // act
            _core.removeBagel(bagel1);

            // assert
            Assert.IsFalse(_core.removeBagel(bagel1));
        }
    }
}