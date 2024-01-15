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

    [Test]
    public void ShouldRemoveBagel()
    {
        Core core = new Core();
        Bagel bagel1 = Bagel.appleCinamon;
        Bagel bagel2 = Bagel.garlic;

        core.Add(bagel1);
        core.Add(bagel2);
        core.Remove(bagel1);
        Assert.That(core.Basket.Count == 1);
        Assert.That(core.Basket.Contains(bagel2));
        Assert.That(!core.Basket.Contains(bagel1));
    }

    [Test]
    public void ShouldChangeCapacity()
    {
        Core core = new Core();
        core.ChangeCapacity(5);

        Assert.That(core.Capacity == 5);
    }

    [Test]
    public void ShouldReturnAfterAdding()
    {
        Core core = new Core();
        Bagel bagel = Bagel.appleCinamon;

        bool add1 = core.Add(bagel);
        core.Add(bagel);
        core.Add(bagel);
        bool add2 = core.Add(bagel);

        Assert.That(add1);
        Assert.That(!add2);
    }

    [Test]
    public void ShouldReturnAfterRemoving()
    {
        Core core = new Core();
        Bagel bagel1 = Bagel.appleCinamon;
        Bagel bagel2 = Bagel.garlic;

        core.Add(bagel1);
        core.Add(bagel2);

        bool rm1 = core.Remove(bagel1);
        bool rm2 = core.Remove(bagel1);

        Assert.That(rm1);
        Assert.That(!rm2);
    }


    [Test]
    public void ChangeCapacityLowerTest()
    {
        Core core = new Core();
        core.Add(Bagel.appleCinamon);
        core.Add(Bagel.garlic);

        core.ChangeCapacity(2);
        Assert.That(!core.Add(Bagel.frenchToast));
    }

    [Test]
    public void ChangeCapacityUpperTest()
    {
        Core core = new Core();
        core.Add(Bagel.appleCinamon);
        core.Add(Bagel.garlic);

        core.ChangeCapacity(5);
        core.Add(Bagel.egg);
        core.Add(Bagel.pumpernickle);
        core.Add(Bagel.blueberryChocolateChip);
        Assert.That(!core.Add(Bagel.everything));
    }
}