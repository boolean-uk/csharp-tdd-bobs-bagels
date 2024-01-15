// See https://aka.ms/new-console-template for more information
using tdd_bobs_bagels.CSharp.Main;

Console.WriteLine("Hello, World!");
Basket basket = new Basket();
basket.AddBagleToBasket(Basket.BagleType.Plain);
basket.AddBagleToBasket(Basket.BagleType.Plain);
basket.AddBagleToBasket(Basket.BagleType.Sourdough);
basket.AddBagleToBasket(Basket.BagleType.Sourdough);
string testText = basket.AddBagleToBasket(Basket.BagleType.Gluten_free);
Console.WriteLine(testText);



