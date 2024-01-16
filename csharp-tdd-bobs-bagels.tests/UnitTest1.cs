using System.Threading.Tasks.Sources;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelTest()
    {

        Core core = new Core();

        core.AddBagel(Core.Bagel.Sesame);

        Assert.That(core._cart.First().Equals(Core.Bagel.Sesame));
    }

    [Test]
    public void RemBagelTest()
    {

        Core core = new Core();

        core.AddBagel(Core.Bagel.Sesame);
        core.AddBagel(Core.Bagel.GlutenFree);

        core.RemoveBagel(Core.Bagel.Sesame);

        Assert.That(core._cart.First().Equals(Core.Bagel.GlutenFree));
    }

    [Test]
    public void IncreaseBasketTest()
    {

        Core core = new Core();

        core.AddBagel(Core.Bagel.Sesame);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);

        core.RemoveBagel(Core.Bagel.Sesame);

        core.IncreaseCapacity();
        core.AddBagel(Core.Bagel.GlutenFree);
        core.AddBagel(Core.Bagel.GlutenFree);

        core.AddBagel(Core.Bagel.GlutenFree);



        Assert.That(core.count > 10);
    }

 

}