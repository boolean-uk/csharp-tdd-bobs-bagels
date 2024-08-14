using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }
    
    [TestCase("bagel1", true, 1)]
    [TestCase("bagel2", true, 11)]
    [TestCase("bagel3", false, 0)]
    public void AddBagelTest(String name, bool expectedResult,  int capacity)
    {
        Basket basket1 = new Basket(capacity);

        bool result = basket1.Add(name);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
    [TestCase("bagel", true, 3, 3)]
    [TestCase("bagel", false, 4, 3)]
    [TestCase("bagel", true, 2, 2)]
    public void RemoveBagelTest(String name, bool expectedResult, int capacity, int amountOfBagels)
    {
        Basket basket1 = new Basket(capacity);

        for (int i = 0; i < amountOfBagels-1; i++)
        {
            bool add = basket1.Add("Bagel7");
            Assert.That(add);
        }
        if (expectedResult)
        {
            bool add2 = basket1.Add(name);
            Assert.That(add2);
        }
        bool result = basket1.Remove(name);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase(10, 6, true)]
    [TestCase(3, 6, true)]
    [TestCase(10, 10, false)]
    public void ChangeCpasityTest(int new_capasity, int old_capasity, bool expectedResult)
    {
        Basket basket = new Basket(old_capasity);
        bool result = basket.changeCapacity(new_capasity);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}