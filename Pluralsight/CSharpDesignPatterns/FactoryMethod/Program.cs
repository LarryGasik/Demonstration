// See https://aka.ms/new-console-template for more information

using FactoryMethod;

Console.Title = "Playing with Factories";

var factories = new List<DiscountFactory>{
    new CodeDiscountFactory(new Guid("12071e50-c8cc-445a-b167-513113fda320")), 
    new CountryDiscountFactory("USA")};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Discount Service: {discountService}, Discount Percentage: {discountService.DiscountPercentage}");
}

Console.ReadKey();