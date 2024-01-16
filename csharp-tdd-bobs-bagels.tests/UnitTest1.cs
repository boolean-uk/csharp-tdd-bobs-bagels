using System.Diagnostics;
using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;
namespace csharp_tdd_bobs_bagels.tests;


public class BasketTest
{
    [Test]
    public void AddItemTest()
    {
        Basket user = new Basket(0);
        Assert.That(user.Items.Count == 0);
        user.AddItem("BGLC");
        Assert.That(user.Items.Count == 1);
    }

    [Test]
    public void RemoveItemTest()
    {
        Basket user = new Basket(0);
        user.AddItem("BGLC");
        Assert.That(user.Items.Count == 1);
        user.RemoveItem(0);
        Assert.That(user.Items.Count == 0);
        Assert.Throws<InvalidOperationException>(() => user.RemoveItem(0));
        Assert.Throws<InvalidOperationException>(() => user.RemoveItem(7));
    }

    [Test]
    public void ItemCapacityTest()
    {
        Basket user = new Basket(0);
        for (int i = 0; i < 5; i++)
        {
            Assert.That(user.HasAvailableSpace() == true);
            user.AddItem("Some bagel");
        }
        Assert.That(user.HasAvailableSpace() == false);
        Assert.Throws<InvalidOperationException>(() => user.AddItem("Additional bagel"));
        user.SetItemCapacityLimit(6);
        user.AddItem("Additional bagel");
        Assert.That(user.Items.Count == 6);
    }

}