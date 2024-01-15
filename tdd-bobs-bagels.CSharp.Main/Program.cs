// See https://aka.ms/new-console-template for more information
using tdd_bobs_bagels.CSharp.Main;

Console.WriteLine("Hello, World!");
Basket basket = new Basket(3);
basket.AddItem("Plain Bagel");
basket.AddItem("Plain Bage l 2");
basket.AddItem("Plain Bagel 3");
foreach (var item in basket.Items)
Console.WriteLine(item);
basket.RemoveItem("Plain Bagel");
foreach (var item in basket.Items)
    Console.WriteLine(item);
basket.ChangeCapacity(3);
basket.AddItem("Plain Bage l 6");
Console.WriteLine(basket.Capacity);
foreach (var item in basket.Items)
    Console.WriteLine(item);
if (basket.IsFull())
{
    Console.WriteLine("Basket is full.");
}
else
{
    Console.WriteLine("Basket is not full.");
}
