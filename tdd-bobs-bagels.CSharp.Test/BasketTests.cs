using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _basket;

        public BasketTests()
        {
            _basket = new Basket();
        }

        [Test]
        public void AddExistingBagle()
        {
            var bagleToAdd = _basket.bagelTypes[0];
            var returnString = _basket.Add(bagleToAdd);
            Assert.That(returnString, Is.EqualTo($"{bagleToAdd} was added to basket"));
        
        }

        [Test]
        public void AddNonBagle()
        {
            var bagleToAdd = "NonExistingBagle";
            var returnString = _basket.Add(bagleToAdd);
            Assert.That(returnString, Is.EqualTo($"{bagleToAdd} is not a valid bagle type"));

        }
        [Test]
        public void AddToFullBasket()
        {
            for (int i = 0; i < 4; i++)
            {
                _basket.Add(_basket.bagelTypes[i]);
            }

            //Above capacity
            string returnString = _basket.Add(_basket.bagelTypes[0]);
            Assert.That(returnString, Is.EqualTo("Basket is full"));
            Assert.That(_basket._basketList.Count, Is.EqualTo(4));

        }

        [Test]
        public void RemoveExisitingBagle()
        {

            Assert.That(_basket.Remove(_basket.bagelTypes[0]), Is.True);
        }

        [Test]
        public void RemoveNonBagle()
        {
            Assert.That(_basket.Remove("NonExistingBagle"), Is.False);
        }

        [Test]
        public void ChangeCapacityTrue()
        {
            Assert.That(_basket.ChangeCapacity(5), Is.True);
        }

        [Test]
        public void ChangeCapacityError()
        {
            //Cant have a negative capacity
            Assert.That(_basket.ChangeCapacity(-1), Is.False);
            //Below Capacity
            Assert.That(_basket.ChangeCapacity(1), Is.False);

        }
    }
}