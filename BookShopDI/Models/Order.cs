namespace BookShopDI.Models;

public record Order(List<CartItem> Items, double TotalPrice, string CustomerName);