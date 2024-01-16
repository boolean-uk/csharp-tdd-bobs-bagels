using System.Threading.Tasks.Sources;
using tdd_bobs_bagels.CSharp.Main;



namespace csharp_tdd_bobs_bagels.tests;
[TestFixture]
public class Tests
{

    [Test]
    public void AddTest()
    {
        A Core core = new Core();

        core.Add("SuperUltraFancy");

        Assert.That(core.Bagels.Count, Is.EqualTo(1));
        Assert.That(core.Bagels[0], Is.EqualTo("SuperUltraFancy"));
    }

    [Test]
    public void RemoveTest()
    {
        A Core core = new Core();

        Core.Add("SuperUltraFancy");
        Core.Remove("SuperUltraFancy");

        Assert.That(core.Bagels.Count, Is.EqualTo(0));
    }
}