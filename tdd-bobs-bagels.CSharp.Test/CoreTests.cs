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
            //core.Basket.Add("bagel onion"); checking if it tests fails when bagel with the same name is there
            bool result = core.AddBagel("bagel onion");

            Assert.IsTrue(result);

        }

        [Test]
        public void IsBagelRemoved() {  
            
            Core core = new Core();
            core.AddBagel("bagel onion");
            core.AddBagel("bagel plain");

            bool result = core.RemoveBagelFromBasket("bagel onion");
            foreach(string k in core.Basket)
            {
                Console.WriteLine(k);
            }
            Assert.IsTrue(result);


        }
    }
}