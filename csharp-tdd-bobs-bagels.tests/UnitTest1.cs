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
        core.add("bagel");
        core.add("differentBagel");
    }

    [Test]
    public void addTest()
    {
        Assert.AreEqual(core.bagels, new List<string>() { "bagel", "differentBagel" });
    }

    [Test]
    public void removeTest() 
    {
        core.remove("differentBagel");
        Assert.AreEqual(core.bagels, new List<string>() { "bagel" });
    }
}