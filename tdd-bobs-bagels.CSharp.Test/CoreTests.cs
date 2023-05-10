using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]   
    
    public class CoreTests
    {
        public CoreTests()
        {
        }

        [Test]
        public void IsBagelAdded() {
           Core core = new Core();
            core.Basket.Add("bagel onion");
            bool result = core.AddBagel("bagel onion");

            Assert.IsTrue(result);


        }
    }
}