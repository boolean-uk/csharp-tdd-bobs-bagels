using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests
{
    public class BasketTest
    {
        [Test]
        public void AddBagelToBasket()
        {
            // Arrange
            Basket basket = new Basket();

            // Act
            basket.AddBagel("Blueberry Bagel", 2);
            basket.AddBagel("Cinnamon Raisin Bagel", 2);

            // Assert
            Assert.That(basket.Items, Is.Not.Null);
            Assert.That(basket.Items.ContainsKey("Blueberry Bagel"));
            Assert.That(basket.Items.ContainsKey("Cinnamon Raisin Bagel"));

        }

        [Test]
        public void RemoveBagel()
        {
            // Arrange
            Basket basket = new Basket();
            basket.AddBagel("Blueberry Bagel", 2);
            basket.AddBagel("Cinnamon Raisin Bagel", 2);

            // Act
            basket.RemoveBagel("Blueberry Bagel");

            // Assert
            Assert.That(basket.Items.Count, Is.EqualTo(1), "Basket should contain 1 bagel.");
            Assert.IsFalse(basket.Items.ContainsKey("Blueberry Bagel"));
        }


        [Test]
        public void IsBasketFull()
        {
            // Arrange
            Basket basket = new Basket();

            //Act
            basket.AddBagel("Blueberry Bagel", 3);
            basket.AddBagel("Cinnamon Raisin Bagel", 4);
            basket.AddBagel("Chocolate Bagel", 5);
            basket.AddBagel("Onion Bagel", 2);
            bool fullBasket = basket.IsBasketFull(basket.Items);

            // Assert
            Assert.That(fullBasket);

        }

        [Test]
        public void ChangeBasketCapacity()
        {
            //Arrange
            Basket basket = new Basket();

            // Act
            bool result = basket.ChangeBasketCapacity(15);


            //Assert
            Assert.IsTrue(result, "Capacity should be changed to 15.");
        }

        [Test]
        public void RemoveItemThatDoesntExist()
        {
            //Arrange
            Basket basket = new Basket();
            basket.AddBagel("Chocolate Bagel", 5);
            basket.AddBagel("Onion Bagel", 2);

            //Act
            bool exists1 = basket.RemoveItemThatDoesntExist("Onion Bagel");
            bool exists2 = basket.RemoveItemThatDoesntExist("Blueberry Bagel");

            //Assert
            Assert.IsTrue(exists1);
            Assert.IsFalse(exists2);
        }
    }
}
