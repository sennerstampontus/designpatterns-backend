using designpatterns_api.Interfaces;
using SharedLib.Factories;
using SharedLib.Models;

IShoe product = GenericFactory.Create<ShoeModel>();


product.Title = "Nike Air";




Console.ReadKey();