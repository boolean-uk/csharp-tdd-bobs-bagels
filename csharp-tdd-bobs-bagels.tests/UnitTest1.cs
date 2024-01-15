using System.Reflection.Emit;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class Tests
{
    [Test]
    public void ShouldAddBagel()
    {
        Core core = new Core();
        Bagel bagel1 = Bagel.appleCinamon;
        Bagel bagel2 = Bagel.garlic;

        core.Add(bagel1);
        core.Add(bagel2);
        Assert.That(core.Basket.Count > 0);
        Assert.That(core.Basket.Contains(bagel2));
        Assert.That(core.Basket.Contains(bagel1));
    }
}