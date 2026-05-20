using BookShopDI.Models;

namespace BookShopDI.Helpers;

public class MessageFormatter
{
    public string FormatOrderConfirmation(Order order)
    {
        Console.WriteLine("Formatting order confirmation message...");
        var lines = order.Items
            .Select(i => $"  - {i.Book.Title} x{i.Quantity} = {i.Book.Price * i.Quantity:F2} UAH");
        return $"""
                === Order Confirmation ===
                Customer: {order.CustomerName}
                Items:
                {string.Join("\n", lines)}
                Total: {order.TotalPrice:F2} UAH
                ==========================
                """;
    }
}