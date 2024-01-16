using System.Threading.Tasks.Sources;
using tdd_bobs_bagels.CSharp.Main;


namespace csharp_tdd_bobs_bagels.tests;
[TestFixture]
public class Tests
{

    [Test]
    public void AddTest()
    {
        Core core = new Core();

        core.Add("SuperUltraFancy");

        Assert.That(core.Bagels.Count, Is.EqualTo(1));
        Assert.That(core.Bagels[0], Is.EqualTo("SuperUltraFancy"));
    }

    [Test]
    public void RemoveTest()
    {
        Core core = new Core();

        core.Add("SuperUltraFancy");
        core.Remove("SuperUltraFancy");

        Assert.That(core.Bagels.Count, Is.EqualTo(0));
    }
    [Test]
    public void Testfull()
    {
        Core core = new Core();
        core.Add("SuperUltraFancy");
        
        Assert.Throws<Exception>(() => core.Add("SuperUltraMegaFancy"));
    }
    [Test]
    public void TestRemoveError()
    {
        Core core = new Core();
        core.Add("SuperUltraFancy");
        Assert.Throws<Exception>(() => core.Add("SuperUltraMegaFancy"));
    }

    [Test]
    public void IncreaseCapacityTest()
    {
        Core core = new Core();
        core.Add("SuperUltraFancy");
        core.IncreaseCapacity();
        core.Add("SuperUltraMegaFancy");
        Assert.That(core.Bagels.Count, Is.EqualTo(2));
    }

}