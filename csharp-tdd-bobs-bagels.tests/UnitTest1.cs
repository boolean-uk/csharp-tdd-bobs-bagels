using NUnit.Framework.Internal;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;


    public class BagelTests
    {
       
        
        [Test]
        public void AddBagel()
        {
            //arrange in SetUp
            BobsBasket basket = new BobsBasket();

            //act
            bool expected = basket.addBagel("Bagel", 10);

        //assert
            Assert.That(expected = true);    
        }

        [Test]
        [TestCase("Pineapple", 1, 1)]
        [TestCase("Pistachio", 5, 0)]
        [TestCase("Whole wheat", 3, 3)]
        public void removeBagel(string type, int amount, int expected)
            {
                BobsBasket basket = new BobsBasket();

                basket.addBagel("Pineapple", 2);
                basket.addBagel("Pistachio", 10);//max per basket is 5, returns 0
                basket.addBagel("Whole wheat", 3);

                basket.removeBagel(type, amount);

                int bagels = basket.roomForMoreBagels();
    
                Assert.That(bagels, Is.EqualTo(expected));

            }

        [Test]  
        public void changeBasketSize()
        {
            BobsBasket basket = new BobsBasket();

            basket.changeBasketSize(10);

            int result = basket.maxAmountOfBagels();

            Assert.That(result == 10);

        }

    
    
    }