using BookShopDI.Models;

namespace BookShopDI.Services;

public class OrderService : IOrderService
{
    private readonly BookCatalog bookCatalog;
    private readonly CartService cartService;
    private readonly NotificationService notificationService;

    public OrderService(
        BookCatalog bookCatalog,
        CartService cartService,
        NotificationService notificationService)
    {
        this.bookCatalog = bookCatalog;
        this.cartService = cartService;
        this.notificationService = notificationService;
    }

    public void ShowCatalog(string genre)
    {
        Console.WriteLine($"\n--- Books in genre '{genre}' ---");
        var books = bookCatalog.GetBooksByGenre(genre);
        foreach (var book in books)
            Console.WriteLine($"[{book.Id}] {book.Title} — {book.Author} — {book.Price} UAH");
    }

    public void AddToCart(int bookId)
    {
        var book = bookCatalog.GetById(bookId);
        if (book is null)
        {
            Console.WriteLine($"Book with id {bookId} not found.");
            return;
        }
        cartService.AddBook(book);
    }

    public Order PlaceOrder(string customerName)
    {
        Console.WriteLine($"\nPlacing order for {customerName}...");
        var items = cartService.GetItems();
        var total = cartService.GetTotal();
        var order = new Order(items, total, customerName);
        notificationService.SendOrderConfirmation(order);
        cartService.Clear();
        return order;
    }
}