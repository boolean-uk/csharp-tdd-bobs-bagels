// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Serialization;
using tdd_bobs_bagels.CSharp.Main;

Console.WriteLine("Hello, World!");


Core core  = new Core();

core.AddBagel(Core.Bagel.Salmon);
core.AddBagel(Core.Bagel.Asiago);

core.RemoveBagel(Core.Bagel.Sesame);