using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Cream Cheese")]
    public void AddBagel(string bagel)
    {
        //Arrange
        Core core = new Core();

        //Act
        core.AddBagel(bagel);

        //Assert
        Assert.IsTrue(core._BasketList.Contains(bagel));
    }

    [TestCase("Cream Cheese")]
    public void RemoveBagel(string bagel)
    {
        //Arrange
        Core core = new Core();

        //Act
        core.AddBagel(bagel);
        core.RemoveBagel(bagel);

        //Assert
        Assert.IsTrue(!core._BasketList.Contains(bagel));
    }

    [Test]
    public void BasketFull() 
    {
        //Arrange
        Core core = new Core();
        string bagel1 = "Cream Chesse";
        string bagel2 = "Eggs";
        string bagel3 = "Ham and cheese";
        string bagel4 = "PLain";

        core.AddBagel(bagel1);
        core.AddBagel(bagel2);
        core.AddBagel(bagel3);
        core.AddBagel(bagel4);

        //Act
        core.AddBagel(bagel4);

        //ASsert
        Assert.IsTrue(!core._basketList.Contains(bagel4));

    }

    [Test]

    public void changeBasketSize()
    {
        //Arrange
        Core core = new Core();
        int s = 3;
        //Act
        core.basketCapacity(s);

        //Assert
        Assert.AreEqual(3, core._capacity);
    }

    [TestCase("Cream Cheese")]
    public void MessageWhenRemoving(string bagel)
    {
        //Arrange
        Core core = new Core();
        string s = ($"{bagel} is not in the basket");

        //Act
        string msg = core.BagelNotInBasket(bagel);
       
        //Assert
        Assert.AreEqual(s, msg);
    }

}