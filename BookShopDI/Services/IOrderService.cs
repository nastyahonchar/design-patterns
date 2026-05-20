using BookShopDI.Models;

namespace BookShopDI.Services;

public interface IOrderService
{
    void ShowCatalog(string genre);
    void AddToCart(int bookId);
    Order PlaceOrder(string customerName);
}