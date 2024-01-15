using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {

        Basket _basket = new();

        [SetUp]
        public void SetUp()
        {
            _basket = new Basket();
        }

        [Test]
        public void OrderBagelTest()
        {
            _basket.Order("Frosted Bagel");
            _basket.Order("Plain Bagel");
            Assert.That(_basket.Orders.Contains("Frosted Bagel"), Is.True);
            Assert.That(_basket.Orders.Contains("Plain Bagel"), Is.True);
        }

        [Test]
        public void OrderBagelThrowsExceptionOnOverfillTest()
        {
            _basket.Capacity = 1;
            _basket.Order("Frosted Bagel");
            Assert.Throws<Exception>(() => _basket.Order("Overflow Bagel"));
        }

        [Test]
        public void RemoveBagelTest()
        {
            _basket.Order("Plain Bagel");
            Assert.That(_basket.Remove("Plain Bagel"), Is.True);
        }

        [Test]
        public void RemoveBagelThrowsExceptionTest()
        {
            _basket.Order("Plain Bagel");
            _basket.Order("Exceptional Bagel");
            Assert.Throws<Exception>(() => _basket.Remove("Out of bounds Bagel"));
        }

        [Test]
        public void ChangeCapacityTest()
        {
            _basket.Capacity = 10;
            Assert.That(_basket.Capacity, Is.EqualTo(10));
        }
    }
}