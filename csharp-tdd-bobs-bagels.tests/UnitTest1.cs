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
}