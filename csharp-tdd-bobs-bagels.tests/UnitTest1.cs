using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using csharp_tdd_bobs_bagels;
using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;


namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    private Basket _basket;

    //create new instance of basket, and add 5 bagels to the basket
    [SetUp]
    public void Setup()
    {
        _basket = new Basket();

        _basket.addBagel("bagel1");
        _basket.addBagel("bagel2");
        _basket.addBagel("bagel3");
        _basket.addBagel("bagel4");
        _basket.addBagel("bagel5");
    }

    //test the add() function
    [Test]
    public void addBagelTest()
    {
        //list to compare with
        List<string> expectedList =
            [
            "bagel1",
            "bagel2",
            "bagel3",
            "bagel4",
            "bagel5"
            ];

        //get the list from instance
        List<string> actualList = _basket.getBagelList();

        //check if list is same as expected
        Assert.That(actualList, Is.EqualTo(expectedList));

        _basket.addBagel("bagel6");

        //check that no more elements than max can be added
        Assert.That(actualList, Is.EqualTo(expectedList));
    }

    [Test]
    public void removeBagelTest() 
    {
        //list to compare with
        List<string> expectedList =
            [
            "bagel1",
            "bagel2",
            "bagel3",
            "bagel4",
            "bagel5"
            ];

        //list to compare with after
        List<string> expectedList2 =
            [
            "bagel2",
            "bagel3",
            "bagel4"
            ];

        //Check first if the list contains all 5 bagels
        Assert.That(_basket.getBagelList, Is.EqualTo(expectedList));

        //Remove bagel 1 and 5
        _basket.removeBagel("bagel1");
        _basket.removeBagel("bagel5");

        //Check that the bagels were succesfully removed
        Assert.That(_basket.getBagelList, Is.EqualTo(expectedList2));

    }

    //test the adjustBasketCapacity function
    [Test]
    public void adjustBasketCapacityTest() 
    {
        //list to compare with
        List<string> expectedList =
            [
            "bagel1",
            "bagel2",
            "bagel3",
            "bagel4",
            "bagel5"
            ];

        //list to compare with after change of capacity
        List<string> expectedList2 =
            [
            "bagel1",
            "bagel2",
            "bagel3",
            "bagel4",
            "bagel5",
            "bagel6"
            ];

        //try add bagel6 to the basket (should'nt be possible due to capacity)
        _basket.addBagel("bagel6");

        //control that the capacity is working
        Assert.That(_basket.getBagelList, Is.EqualTo(expectedList));

        //change capacity and add bagel 6 again
        _basket.adjustBasketCapacity(6);
        _basket.addBagel("bagel6");

        //check that bagel6 were succesfully added
        Assert.That(_basket.getBagelList, Is.EqualTo(expectedList2));

    }

    
}