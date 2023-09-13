using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
       public void AddBagel()
        {
            // arrange

            Basket bagel = new Basket(3);
                


            // act
            bagel.Items.Add("Cheese");


            // assert
            Assert.IsTrue(1 == bagel.Items.Count);

        }

        [Test]
        public void RemoveBagel() 
        {
            // arrange
            Basket bagel = new Basket(3);
            bagel.Items.Add("Cheese");
            bagel.Items.Add("Ham");
            bagel.Items.Add("Peanut Butter");

            // act

            bagel.RemoveBagel("Ham");

            // assert
            Assert.IsTrue(2 == bagel.Items.Count);

        }

        //[Test]
        //public void MaximumBagel()
        //{
        //    // arrange
        //    Basket bagel = new Basket(3);
        //    bagel.Items.Add("Cheese");
        //    bagel.Items.Add("Ham");
        //    bagel.Items.Add("Peanut Butter");

        //    // act
        //    bagel.Items.Add("Mozzarella");
        //    bagel.Items.Add("Mozzarella");
        //    bagel.Items.Add("Mozzarella");


        //    // assert
        //    Assert.IsTrue (bagel.Items.Count <= 3);

        

        [Test]
        public void MaximumBagelTwo()
        {
            Basket bagel = new Basket(4 );
            bagel.AddAnotherBagel("Cheese");
            bagel.AddAnotherBagel("Blood");
            bagel.AddAnotherBagel("Sweat");
            bagel.AddAnotherBagel("Tears");
            //bagel.AddAnotherBagel("Tears");

            bool result = bagel.AddAnotherBagel("Ham");

            Assert.IsFalse(result);

        }

        [Test]
        public void IncreaseMaximumBagel()
        {
            // arrange
            Basket bagel = new Basket(5);
            bagel.AddAnotherBagel("Cheese");
            bagel.AddAnotherBagel("Blood");
            bagel.AddAnotherBagel("Sweat");
            bagel.AddAnotherBagel("Tears");

            bool result = bagel.AddAnotherBagel("Ham");

            Assert.IsTrue(result);

        }

        [Test]
        public void SearchBagels()
        {
            // arange
            Basket bagel = new Basket(3);
            bagel.Items.Add("Cheese");
            bagel.Items.Add("Ham");
            bagel.Items.Add("Peanut Butter");
            bagel.Items.Remove("Bacon");

            // act
            string result = bagel.SearchBagelByName("Bacon");

            // assert
            Assert.AreEqual(result, "Are you insane?!");

        }
    }
}