using BookShopDI.Helpers;
using BookShopDI.Models;

namespace BookShopDI.Services;

public class NotificationService
{
    private readonly MessageFormatter messageFormatter;

    public NotificationService(MessageFormatter messageFormatter)
    {
        this.messageFormatter = messageFormatter;
    }

    public void SendOrderConfirmation(Order order)
    {
        Console.WriteLine("Sending order confirmation...");
        var message = messageFormatter.FormatOrderConfirmation(order);
        Console.WriteLine(message);
    }
}