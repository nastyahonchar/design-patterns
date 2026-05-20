using BookShopDI.Models;

namespace BookShopDI.Helpers;

public class PriceCalculator
{
    public double CalculateTotal(List<CartItem> items)
    {
        Console.WriteLine("Calculating total price...");
        return items.Sum(item => item.Book.Price * item.Quantity);
    }
}