using BookShopDI.Helpers;
using BookShopDI.Models;

namespace BookShopDI.Services;

public class CartService
{
    private readonly PriceCalculator priceCalculator;
    private readonly DiscountService discountService;

    private readonly List<CartItem> items = new();

    public CartService(PriceCalculator priceCalculator, DiscountService discountService)
    {
        this.priceCalculator = priceCalculator;
        this.discountService = discountService;
    }

    public void AddBook(Book book, int quantity = 1)
    {
        Console.WriteLine($"Adding to cart: {book.Title} x{quantity}");
        items.Add(new CartItem(book, quantity));
    }

    public double GetTotal()
    {
        var rawTotal = priceCalculator.CalculateTotal(items);
        return discountService.ApplyDiscount(rawTotal, items.Count);
    }

    public List<CartItem> GetItems() => items;

    public void Clear()
    {
        items.Clear();
        Console.WriteLine("Cart cleared.");
    }
}