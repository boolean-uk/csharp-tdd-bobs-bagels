using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BagelsTest
    {
             
        [TestCase("regular bagel")]
        public void AddBagelTest(string bagel)
        {
            Bagels bagels = new Bagels();
            bagels.AddBagel(bagel);
            Assert.AreEqual(1, bagels.BagelBasket.Count);
        }
    }
}