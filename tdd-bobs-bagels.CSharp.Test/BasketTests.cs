using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    public class BasketTests
    {
        private Basket _basket;

        [SetUp]
        public void SetUp()
        {
            _basket = new Basket();
        }

        [Test]
        public void addBageltest()
        {
            //testing if the bagel is being addded
            bool result = _basket.addBagel("Plain");
            Assert.That(result, Is.EqualTo(true));

            List<string> expected = new List<string> {"Plain"};

            //Assert if list contains "Plain"
            Assert.That(result, Is.EqualTo(expected));
        }



        [Test]
        public void addBageltest2() 
        {
            //testing if the basket is full
            bool message = _basket.addBagel("Chilli");
            Assert.That(message, Is.EqualTo("The basket is full"));

        }



        [Test]
        public void removeTest()
        {
            //testing if an item can be removed
            _basket.addBagel("Plain");
            _basket.addBagel("Chilli");
            bool result = _basket.removeBagel("Plain");
            Assert.That(result, Is.EqualTo(true));


            //testing that the item is not in the list anymore
            List<string> expected = new List<string> {"Chilli"};

            //Assert tha list does not contains "Plain"
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void removeTest2()
        {
            //testing if the basket is full
            _basket.addBagel("Plain");
            bool message = _basket.removeBagel("Chilli");

            Assert.That(message, Is.EqualTo("The basket is full"));
        }



        [Test]
        //testing if the capacity of the basket will be changed as expected
        public void changeCapacityTest()
        {
            int result = _basket.changeCapacity(2);

            Assert.That(result, Is.EqualTo(0));
        }


    }
}