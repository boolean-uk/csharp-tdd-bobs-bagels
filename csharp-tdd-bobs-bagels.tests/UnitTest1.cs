using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void testAdd()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        string bagel1 = "bread";
        string bagel2 = "crossiant";
        basket.Add("bread");
        basket.Add(bagel2);
        List<string> testResult = new List<string>() { 
            bagel1, bagel2
        };


        //Assert
        Assert.AreEqual(testResult, basket._basket);

    }
}