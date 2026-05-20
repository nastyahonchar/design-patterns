using BookShopDI.Models;

namespace BookShopDI.Helpers;

public class BookSorter
{
    public List<Book> SortByPrice(List<Book> books)
    {
        Console.WriteLine("Sorting books by price...");
        return books.OrderBy(b => b.Price).ToList();
    }

    public List<Book> SortByTitle(List<Book> books)
    {
        Console.WriteLine("Sorting books by title...");
        return books.OrderBy(b => b.Title).ToList();
    }
}