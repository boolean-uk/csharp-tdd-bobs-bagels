using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests
{ 
    public class Tests
    {
        [Test]
        public void AddBagel()
        {
            // arrange
            Basket basket = new Basket();
            // act
            bool result = basket.AddBagel("Bagel");
            // assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void RemoveBagel()
        {
            // arrange
            Basket basket = new Basket();
            // act
            bool result = basket.RemoveBagel("Bagel");
            // assert
            Assert.That(result, Is.True);
        }
        
        [Test]
        public void ChangeBasketCapacity()
        {
            // arrange
            Basket basket = new Basket();
            basket.AddBagel("Blueberry bagel");
            int expected = 6;
            // act
            int result = basket.ChangeCapacity(6);
            // assert
            Assert.That(expected == result);
        }

        [Test]
        public void RemoveNonExistingBagel()
        {
            // arrange
            Basket basket = new Basket();
            basket.AddBagel("Blueberry");
            basket.RemoveBagel("Blueberry");
            // act
            bool result = basket.Items.Contains("Blueberry");
            // assert
            Assert.That(result, Is.False);
        }

    }
}
