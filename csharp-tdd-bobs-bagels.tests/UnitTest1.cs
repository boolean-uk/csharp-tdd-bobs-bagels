using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAdd()
    {
        Core core = new Core();

        core.Add("Plain");

        Assert.That(core.Bagels.Count, Is.EqualTo(1));
        Assert.That(core.Bagels[0], Is.EqualTo("Plain"));
    }

    [Test]
    public void TestAddFull()
    {
        Core core = new Core();

        core.Add("Plain");
        core.Add("Sour-Dough");
        core.Add("French");
        core.Add("Cheese");
        core.Add("Egg");

        Assert.Throws<Exception>(() => core.Add("Chocolate"));
    }

    public void TestRemove()
    {
        Core core = new Core();

        core.Add("Plain");
        core.Remove("Plain");

        Assert.That(core.Bagels.Count, Is.EqualTo(0));
    }
}