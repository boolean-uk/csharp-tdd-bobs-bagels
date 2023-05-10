using NUnit.Framework;
using System.ComponentModel;
using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        //As a member of the public,
        //So I can order a bagel before work,
        //I'd like to add a specific type of bagel to my basket.


        [TestCase("Plain Bagel")]
        public void AddBagelToBasket(string bagel)
        {
            //arrange
            Basket basket = new Basket();

            // act
            basket.AddBagel(bagel);

            //assert
            Assert.AreEqual(basket.Bagels.Count, 1);
        }



        //As a member of the public,
        //So I can change my order,
        //I'd like to remove a bagel from my basket.
        [TestCase("Cheese Bagel")]
        public void RemoveBagelFromBasket(string bagel)
        {

            //arrange
            Basket basket = new Basket();
            basket.AddBagel(bagel);

            //act
            bool result = basket.RemoveFromBasket(bagel);

            //assert
            Assert.IsTrue(result);
            Assert.AreEqual(basket.Bagels.Count, 0);
        }

        //As a member of the public,
        //So that I can not overfill my small bagel basket
        //I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
        []

    }
}