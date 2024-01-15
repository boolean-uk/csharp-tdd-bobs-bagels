using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        private Basket _basket;
        public BasketTest()
        {
            _basket = new Basket();
        }


        [SetUp]
        public void SetUp() 
        {
            _basket.basket = new List<Basket.Bagle>();
        }

        [Test] 
        public void FirstTest() 
        {
            //AddBagleToBasket

            string testText = _basket.AddBagleToBasket(Basket.BagleType.Sourdough);

            Assert.That(testText, Is.EqualTo(new string("Sourdough Bagle added to basket")));
        }
        [Test]
        public void SecondTest()
        {
            //AddBagleToBasket

            string testText = _basket.AddBagleToBasket(Basket.BagleType.Gluten_free);
            Console.WriteLine(testText);
            testText = _basket.AddBagleToBasket(Basket.BagleType.Plain);
            Console.WriteLine(testText);
            testText = _basket.AddBagleToBasket(Basket.BagleType.Sourdough);
            Console.WriteLine(testText);
            testText = _basket.AddBagleToBasket(Basket.BagleType.Sourdough);
            Console.WriteLine(testText);
            testText = _basket.AddBagleToBasket(Basket.BagleType.Gluten_free);
            Console.WriteLine(testText);

            Assert.That(testText, Is.EqualTo(new string("Basket is full. Will not fitt last gluten_free Bagle")));
            Assert.That(_basket.basket.Count, Is.EqualTo(4));
        }

        [Test]
        public void ThirdTest()
        {
            //RemoveBagle

            _basket.AddBagleToBasket(Basket.BagleType.Plain);
            _basket.AddBagleToBasket(Basket.BagleType.Plain);
            _basket.AddBagleToBasket(Basket.BagleType.Sourdough);
            _basket.AddBagleToBasket(Basket.BagleType.Plain);


            Assert.That(_basket.basket.Count(), Is.EqualTo(4)); 

            string testText = _basket.RemoveBagle(Basket.BagleType.Plain);


            Assert.That(testText, Is.EqualTo(new string("Plain Bagle was removed from basket")));
            Assert.That(_basket.basket.Count, Is.EqualTo(3));
            
        }

        [Test]
        public void FourthTest()
        {
            //RemoveBagle
            _basket.AddBagleToBasket(Basket.BagleType.Sourdough);
            _basket.AddBagleToBasket(Basket.BagleType.Plain);

            string testText = _basket.RemoveBagle(Basket.BagleType.Gluten_free);


            Assert.That(testText, Is.EqualTo(new string("Gluten_free Bagle does not exist in basket!")));
        }

        [Test]
        public void FifthTest()
        {
            //ChangeBasketSize

            string testText = _basket.ChangeBasketSize(6);

            Assert.That(testText, Is.EqualTo(new string("basketsize was changed from 4 to 6 ")));

        }


    }
}