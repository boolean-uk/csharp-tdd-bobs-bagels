// See https://aka.ms/new-console-template for more information
using tdd_bobs_bagels.CSharp.Main;

Console.WriteLine("Hello, World!");
Basket _basket;
_basket = new Basket(6);
_basket.addBagel("poppy seed");
_basket.addBagel("cream cheese");
_basket.addBagel("smoked ham");
_basket.addBagel("bacon");
_basket.addBagel("standard");
_basket.removeBagel("bacon");