using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class CoreTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void addTest()
    {
        Core core = new Core();

        bool bagel1 = core.add("Plain");
        bool bagel2 = core.add("Egg");
        bool bagel3 = core.add("Sourdough");
        bool bagel4 = core.add("Blueberry");

        Assert.IsTrue(bagel1);
        Assert.IsTrue(bagel2);
        Assert.IsTrue(bagel3);
        Assert.IsTrue(!bagel4);
    }

    [Test]
    public void removeTest()
    {
        Core core = new Core();

        core.add("Plain");
        core.add("Egg");
        bool removed1 = core.remove("Plain");
        bool removed2 = core.remove("Egg");
        bool removed3 = core.remove("Egg");
        bool removed4 = core.remove("Sourdough");

        Assert.IsTrue(removed1);
        Assert.IsTrue(removed2);
        Assert.IsTrue(!removed3);
        Assert.IsTrue(!removed4);
    }

    [Test]
    public void setCapasityTest()
    {
        Core core = new Core();

        core.setCapacity(1);
        bool bagel1 = core.add("Plain");
        bool bagel2 = core.add("Egg");

        Assert.IsTrue(bagel1);
        Assert.IsTrue(!bagel2);
    }
}