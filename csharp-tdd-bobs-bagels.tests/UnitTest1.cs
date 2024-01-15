using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void addTest()
    {
        Core core = new Core();
        core.add("bagel");
        core.add("differentBagel");
        Assert.Pass();
    }
}