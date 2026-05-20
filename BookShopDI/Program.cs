using BookShopDI.Helpers;
using BookShopDI.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<IOrderService, OrderService>();
services.AddSingleton<BookCatalog>();
services.AddSingleton<CartService>();
services.AddSingleton<NotificationService>();
services.AddTransient<BookFilter>();
services.AddTransient<BookSorter>();
services.AddTransient<PriceCalculator>();
services.AddTransient<DiscountService>();
services.AddTransient<MessageFormatter>();

var provider = services.BuildServiceProvider();

var orderService = provider.GetRequiredService<IOrderService>();

orderService.ShowCatalog("Programming");
orderService.AddToCart(1);
orderService.AddToCart(2);
orderService.AddToCart(3);
orderService.PlaceOrder("Olena");