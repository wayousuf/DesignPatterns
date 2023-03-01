using FactoryMethod.Factory;

var factories = new List<DiscountFactory>
{
    new LocationDiscountFactory("A"),
    new CodeDiscountFactory("coupon1121")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage: {discountService.Percentage}");
}

Console.ReadKey();