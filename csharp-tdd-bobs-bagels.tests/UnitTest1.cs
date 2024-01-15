using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    Core core;

    [SetUp]
    public void Setup()
    {
        core = new Core();
        core.Add(Bagel.appleCinamon);
        core.Add(Bagel.blueberryChocolateChip);
    }

    [Test]
    public void addTest()
    {
        Assert.AreEqual(core.bagels, new List<Bagel>() { Bagel.appleCinamon, Bagel.blueberryChocolateChip });
    }

    [Test]
    public void removeTest() 
    {
        core.Remove(Bagel.blueberryChocolateChip);
        Assert.AreEqual(core.bagels, new List<Bagel>() { Bagel.appleCinamon });
    }

    [Test]
    public void addReturnTrue() {
        Assert.IsTrue(core.Add( Bagel.frenchToast ));
    }

    [Test]
    public void addReturnFalse()
    {
        core.Add(Bagel.plain);
        Assert.IsFalse(core.Add(Bagel.frenchToast));
    }

    [Test]
    public void changeCapacityLowerTest()
    {
        core.changeCapacity(2);
        Assert.IsFalse(core.Add(Bagel.frenchToast));
    }

    [Test]
    public void changeCapacityUpperTest() 
    {
        core.changeCapacity(5);
        core.Add(Bagel.egg);
        core.Add(Bagel.pumpernickle);
        core.Add(Bagel.blueberryChocolateChip);
        Assert.IsFalse(core.Add(Bagel.everything));
    }

    [Test]
    public void removeExisting()
    {
        Assert.True(core.Remove(Bagel.appleCinamon));
    }

    [Test]
    public void removeNonexisting()
    {
        Assert.False(core.Remove(Bagel.plain));
    }
}