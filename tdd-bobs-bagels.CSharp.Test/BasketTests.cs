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
            string message1;
            bool result = _basket.addBagel("Plain", out message1);
            Assert.That(result, Is.EqualTo(true));

            List<string> expected = new List<string> {"Plain"};

            //Assert if list contains "Plain"
            Assert.That(_basket.GetBasketContent, Is.EqualTo(expected));
        }



        [Test]
        public void addBageltest2() 
        {
            //testing if the basket is full
            string message1;
            _basket.addBagel("Chilli", out message1 );
            _basket.addBagel("Chilli", out message1);
            _basket.addBagel("Cheese", out message1);
            Assert.That(message1, Is.EqualTo("Basket is full"));

        }


        
        [Test]
        public void removeTest()
        {
            
            string message3;
            //testing if an item can be removed
            _basket.addBagel("Plain", out message3);
            _basket.addBagel("Chilli", out message3);
            bool result1 = _basket.removeBagel("Plain", out message3);
            Assert.That(result1, Is.EqualTo(true));

            
            //testing that the item is not in the list anymore
            List<string> expected1 = new List<string> {"Chilli"};

            //Assert tha list does not contains "Plain"
            Assert.That(_basket.GetBasketContent(), Is.EqualTo(expected1));

        }


        
        [Test]
        public void removeTest2()
        {
            string message2;
            //testing if the basket is full
            _basket.addBagel("Plain", out message2);
            bool message = _basket.removeBagel("Chilli", out message2);

            Assert.That(message2, Is.EqualTo("Item not in basket"));

        }


        
        [Test]
        //testing if the capacity of the basket will be changed as expected
        public void changeCapacityTest()
        {
            int result = _basket.changeCapacity(2);

            Assert.That(result, Is.EqualTo(2));
        }
        

    }
}