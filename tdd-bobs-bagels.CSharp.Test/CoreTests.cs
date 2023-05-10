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
            core.AddBagel("bagel onion");
            core.AddBagel("bagel plain");
            

            Assert.IsTrue(core.BasketCapacity < core.MaxCapacity);

        }

        [Test]
        public void IsBagelRemoved() {  
            
            Core core = new Core();
            core.AddBagel("bagel onion");
            core.AddBagel("bagel plain");

            bool result = core.RemoveBagelFromBasket("bagel onion");
            //the code below shows the whole basket after the removed bagel
            //foreach(string k in core.Basket)
            //{
            //    Console.WriteLine(k);
            //}
            Assert.IsTrue(result);


        }

        [TestCase(10)]
        [TestCase(6)]

        public void IsCapacityChanged(int v) {
            Core core = new Core();
            Console.WriteLine($"max cap before {core.MaxCapacity}");
            core.ChangeCapacity(v);
            Console.WriteLine($"max cap after {core.MaxCapacity}");

            Assert.AreEqual(core.MaxCapacity, v);
        
        
        }
    }
}