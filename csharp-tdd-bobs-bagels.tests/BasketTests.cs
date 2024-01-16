using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddingBagelToBakset()
    {
        Basket basket = new Basket();

        basket.Add("test"); 

        Assert.AreEqual("test", basket.ToString());
    }
}