using NUnit.Framework;
using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;


namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void Test_One() //Add a bagel to the basket
        {
            //arrange
            Core core = new Core();

            //act
            core.AddBagel("Sesame bagel");

            //assert
            Assert.That(core.Basket.Contains("Sesame bagel"));
        }

        [Test]
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
        {
            //arrange
            Core core = new Core();
            core.AddBagel("Sesame bagel");
            core.AddBagel("Blueberry bagel");
            core.AddBagel("Montreal bagel");
            string expected = "Basket is full";

            //act
            string result = core.AddBagel("Everything bagel");

            //assert
            Assert.That(result, Is.EqualTo(expected));

        }
        public void Test_Four() //Manager increases (changes) max capacity
        { }
        public void Test_Five() //Remove bagel that doesn't exist
        { }

    }
}