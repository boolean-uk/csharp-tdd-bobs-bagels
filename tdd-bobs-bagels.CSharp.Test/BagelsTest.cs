using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

/*
 1.
As a member of the public, So I can order a bagel before work, I'd like to add a specific type of bagel to my basket.
 
2.
As a member of the public, So I can change my order, I'd like to remove a bagel from my basket.
 
 3.
As a member of the public, So that I can not overfill my small bagel basket I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
 
 4.
As a Bob's Bagels manager, So that I can expand my business, I’d like to change the capacity of baskets.

5.
As a member of the public So that I can maintain my sanity I'd like to know if I try to remove an item that doesn't exist in my basket.
 */


namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BagelsTest
    {
             
        [TestCase("regular")]
        public void AddBagelTest(string bagel)
        {
            Bagels bagels = new Bagels();
            bagels.AddBagel(bagel);
            Assert.AreEqual(1, bagels.BagelBasket.Count);
        }

        [TestCase("regular")]
        public void RemoveBagelTest(string bagel) 
        {
            Bagels bagels = new Bagels();
            bagels.AddBagel(bagel);

            bool result = bagels.RemoveBagel(bagel);
            Assert.IsTrue(result);
            Assert.AreEqual(bagels.BagelBasket.Count, 0);
        }

        [Test]
        public void FullBasketTest()
        {
            Bagels bagels = new Bagels();
            string bagel1 = "regular";
            string bagel2 = "cheese";
            string bagel3 = "everything";
            string bagel4 = "sesame";

            bagels.AddBagel(bagel1);
            bagels.AddBagel(bagel2);
            bagels.AddBagel(bagel3);
            bagels.AddBagel(bagel4);

            Assert.AreEqual(bagels.BagelBasket.Count, bagels.BagelBasketMax);
            Assert.IsTrue(bagels.BagelBasketFull);
        }

        [TestCase(4)]
        public void ChangeBasketMax(int value) 
        {
            Bagels bagels = new Bagels();
            string bagel1 = "regular";
            string bagel2 = "cheese";
            string bagel3 = "everything";
            string bagel4 = "sesame";

            bagels.AddBagel(bagel1);
            bagels.AddBagel(bagel2);
            bagels.AddBagel(bagel3);
            bagels.AddBagel(bagel4);
            bagels.SetBagelBasketMax(value);

            Assert.AreEqual(bagels.BagelBasketMax, 4);
        }

        [TestCase("blue")]
        public void RemovedItemExist(string removingBagel)
        {
            Bagels bagels = new Bagels();
            string bagel1 = "regular";
            string bagel2 = "cheese";
            string bagel3 = "everything";
            
            bagels.AddBagel(bagel1);
            bagels.AddBagel(bagel2);
            bagels.AddBagel(bagel3);
            bagels.RemoveBagel(removingBagel);
            Assert.IsTrue(bagels.RemoveBagel(removingBagel) == false);

        }

    }
}