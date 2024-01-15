using NUnit.Framework;
using System.IO;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _core;

        [SetUp]
        public void SetUp()
        {
            _core = new Basket();
        }

        [Test]
        public void AddingWorks()
        {
            _core.Add("hi");

            List<string> l1 = _core._basket;

            Assert.That(0, Is.EqualTo(l1.Count));

            _core.Add("A");

            Assert.That(1, Is.EqualTo(l1.Count));


        }

        [Test]
        public void RemovingWorks()
        {
            _core.Add("A");
            _core.Add("B");

            _core.Remove("D");

            List<string> l1 = _core._basket;

            Assert.That(2, Is.EqualTo(l1.Count));

            _core.Remove("A");

            Assert.That(1, Is.EqualTo(l1.Count));

            Assert.That("B", Is.EqualTo(l1[0]));

        }

        [Test]
        public void CannotRemoveIfMissing()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            _core.Add("A");
            _core.Remove("B");

            List<string> l1 = _core._basket;
            Assert.That(1, Is.EqualTo(l1.Count));

            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.That("Bagel B not in the basket!", Is.EqualTo(outputLines[0]));

        }

        [Test]
        public void CapacityExceeded()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            _core.Add("A");
            _core.Add("B");
            _core.Add("A");
            _core.Add("B");
            _core.Add("C");

            _core.Add("C");
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.That("Basket size exceeded!", Is.EqualTo(outputLines[0]));
        }

        [Test]
        public void ChangeCapacity()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            _core.ChangeCapacity(3);

            _core.Add("A");
            _core.Add("B");
            _core.Add("A");

            _core.Add("B");
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.That("Basket size exceeded!", Is.EqualTo(outputLines[0]));


        }
    }
}