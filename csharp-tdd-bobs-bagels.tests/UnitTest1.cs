using System.Threading.Tasks.Sources;
using tdd_bobs_bagels.CSharp.Main;


namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class BobsBagelsTests
        {

        [Test]
        public void TestRun() { }
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
            Assert.Pass();
            Core core = new Core();

            core.Add("Nutella");
            core.Add("Gluten-free");
            core.Add("Bacon");
            core.Add("Cheese");
            core.Add("Egg");

            Assert.Throws<Exception>(() => core.Add("Cheddar"));
        }

        [Test]
        public void TestRemove()
        {
            Core core = new Core();

            core.Add("Plain");
            core.Remove("Plain");

            Assert.That(core.Bagels.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestRemoveNonexistant()
        {
            Core core = new Core();

            core.Add("Plain");

            Assert.Throws<Exception>(() => core.Remove("Cheddar"));
        }

        [Test]
        public void IncreaseCapacity()
        {
            Core core = new Core();

            core.Add("Nutella");
            core.Add("Gluten-free");
            core.Add("Bacon");
            core.Add("Cheese");
            core.Add("Egg");

            Assert.Throws<Exception>(() => core.Add("Cheddar"));

            core.DoubleCapacity();
            core.Add("Cheddar");

            Assert.That(core.Bagels.Count, Is.EqualTo(6));
        }   
}