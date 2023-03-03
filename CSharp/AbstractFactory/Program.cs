

using AbstractFactory;
using AbstractFactory.Factory;
using AbstractFactory.Services;

var hondayFactory = new HondaCarFactory(HondaProduct.Accord, "TX");
var hondaShoppingCart = new ShopingCart(hondayFactory);

var toyotaFactory = new ToyotaCarFactory(ToyotaProduct.Sienna, "NY");
var toyotaShoppingCart = new ShopingCart(toyotaFactory);

Console.WriteLine($"Honda Car Cost: {hondaShoppingCart.Purchase}");
Console.WriteLine($"Toyota Car Cost: {toyotaShoppingCart.Purchase}");


