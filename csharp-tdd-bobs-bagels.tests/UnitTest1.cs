using System.Security.Cryptography.X509Certificates;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    [Test]
    public void FirstTest()
    {
        Core basket = new Core();
        

        bool addTest = basket.addBagel("Cheese");

        Assert.IsTrue(addTest);

    }
    [Test]
    public void SecondTest()
    {
        Core basket = new Core();

        basket.maxCap(1);

        basket.addBagel("Onion");

        bool addTest = basket.addBagel("Cheese");

        Assert.IsFalse(addTest);
    }
    [Test]
    public void ThirdTest()
    {
        Core basket = new Core();

        basket.addBagel("Cheese");

        bool removeTest = basket.removeBagel("Cheese");

        Assert.IsTrue(removeTest);
    }
    [Test]
    public void FourthTest()
    {
        Core basket = new Core();

        bool removeTest = basket.removeBagel("Cheese");

        Assert.IsFalse(removeTest);
    }
    [Test]
    public void FifthTest() 
    {
        Core basket = new Core();

        bool capTest = basket.maxCap(1);

        Assert.IsTrue(capTest);
    
    }






}

