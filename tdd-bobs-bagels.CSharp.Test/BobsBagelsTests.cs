using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BobsBagelsTests
    {
        private BobsBagels _basket;
        public BobsBagelsTests()
        {
            _basket = new BobsBagels();
        }
        [Test]
        public void InitialTest()
        {
            Assert.Pass();
        }
    }
}