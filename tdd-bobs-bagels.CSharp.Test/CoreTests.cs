using NUnit.Framework.Interfaces;
using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;
using System.Reflection.Emit;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        string bagel1 = "normal bagel";
        string bagel2 = "salty bagel";
        string bagel3 = "sweet bagel";

        [Test]
        public void AddTest()
        {
            //arrange
            Core core = new Core();

            //act
            core.AddBagel(core.basket,bagel1);
            core.AddBagel(core.basket, bagel2);
            core.AddBagel(core.basket, bagel3);

            //assert
            Assert.IsTrue(core.basket.Contains(bagel1));
        }

        [Test]
        public void RemoveTest()
        {
            //arrange
            Core core = new Core();

            //act
            core.RemoveBagel(core.basket, bagel3);

            //assert
            Assert.IsFalse(core.basket.Contains(bagel3));
        }

        [Test]
        public void UpdateCap()
        {
            //arrange
            Core core = new Core();
            int newcap = 7;
            //act
            core.UpdateCapacity(core.basket, newcap);

            //assert
            Assert.IsTrue(core.capacity==newcap);
        }


    }
}