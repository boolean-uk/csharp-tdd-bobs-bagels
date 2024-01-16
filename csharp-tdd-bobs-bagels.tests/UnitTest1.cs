using System.Xml.Linq;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    Basket _basket = new Basket();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        _basket = new Basket();

        bool result = _basket.AddBagel("Bagel");

        Assert.IsTrue(result);
    }

    [TestCase("Bagel", "Bagel", true)]
    [TestCase("Bagel", "OnionBagel", false)]
    [TestCase("SourCreamBagel", "SourCreamBagel", true)]
    [TestCase("SourCreamBagel", "Bagel", false)]

    public void Test2(string name1, string name2, bool finalResult)
    {
        _basket = new Basket();

        _basket.AddBagel(name1);

        bool result = _basket.RemoveBagel(name2);

        Assert.That(result, Is.EqualTo(finalResult));
    }

    [Test]
    public void Test3()
    {
        _basket = new Basket(3);

        _basket.AddBagel("Bagel1");
        _basket.AddBagel("Bagel2");
        _basket.AddBagel("Bagel3");
        bool result = _basket.AddBagel("PoisonBagel");

        Assert.IsFalse(result);

    }

    [Test]
    public void Test4()
    {
        _basket = new Basket(1); //Start capacity of 1

        _basket.AddBagel("Bagel1");
        _basket.AddBagel("Bagel2");

        _basket.UpdateCapacity(3);

        _basket.AddBagel("Bagel3");
        _basket.AddBagel("Bagel4");

        Assert.That(3, Is.EqualTo(_basket.BasketList.Count));
    }

    [Test]
    public void Test5()
    {
        _basket = new Basket();

        _basket.AddBagel("Bagel1");

        bool result = _basket.RemoveBagel("Bagel2");

        Assert.IsFalse(result);
    }
}