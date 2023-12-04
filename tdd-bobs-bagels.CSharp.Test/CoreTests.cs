using NUnit.Framework;
using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;


namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        public void Test_One() //Add a bagel to the basket
        {
            //arrange
            Core core = new Core();

            //act
            core.AddBagel("Sesame bagel");

            //assert
            Assert.IsTrue(core.Basket.Contains("Sesame bagel"));
        }

        public void Test_Two() //Remove a bagel from the basket
        {
            //arrange
            Core core = new Core();
            core.AddBagel("Sesame bagel");
            core.AddBagel("Blueberry bagel");

            //act
            core.RemoveBagel("Sesame bagel");

            //assert
            Assert.That(core.Basket.Contains("Sesame bagel"), Is.False);
        }

        public void Test_Three() //Add bagel when basket is full
        { }
        public void Test_Four() //Manager increases max capacity
        { }
        public void Test_Five() //Remove bagel that doesn't exist
        { }

    }
}