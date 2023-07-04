// See https://aka.ms/new-console-template for more information
using OenClosed;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne GELİŞİME [AÇIK], DEĞİŞİME [KAPALI] OLMALIDIR!
 * 
 */
Product product = new Product() { Name = "Sandviç", Price = 50, Campaign = new QuarterFree() };
OrderManagement orderManagement = new OrderManagement();
var totalPrice = orderManagement.GetDiscountedPrice(product);
Console.WriteLine(totalPrice);



