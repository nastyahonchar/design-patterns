using BookShopDI.Models;

namespace BookShopDI.Helpers;

public class BookFilter
{
    public List<Book> FilterByGenre(List<Book> books, string genre)
    {
        Console.WriteLine($"Filtering books by genre: {genre}");
        return books.Where(b => b.Genre == genre).ToList();
    }

    public List<Book> FilterByMaxPrice(List<Book> books, double maxPrice)
    {
        Console.WriteLine($"Filtering books by max price: {maxPrice}");
        return books.Where(b => b.Price <= maxPrice).ToList();
    }
}