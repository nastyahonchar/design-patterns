using BookShopDI.Helpers;
using BookShopDI.Models;

namespace BookShopDI.Services;

public class BookCatalog
{
    private readonly BookFilter bookFilter;
    private readonly BookSorter bookSorter;

    public BookCatalog(BookFilter bookFilter, BookSorter bookSorter)
    {
        this.bookFilter = bookFilter;
        this.bookSorter = bookSorter;
    }

    private readonly List<Book> allBooks = new()
    {
        new(1, "Clean Code", "Robert Martin", "Programming", 450),
        new(2, "The Pragmatic Programmer","Hunt & Thomas",  "Programming", 380),
        new(3, "Design Patterns", "Gang of Four",  "Programming", 520),
        new(4, "Harry Potter", "J.K. Rowling",  "Fiction", 290),
        new(5, "Dune", "Frank Herbert", "Fiction", 310),
        new(6, "Kobzar", "T. Shevchenko", "Poetry", 150),
    };

    public List<Book> GetBooksByGenre(string genre)
    {
        var filtered = bookFilter.FilterByGenre(allBooks, genre);
        return bookSorter.SortByPrice(filtered);
    }

    public List<Book> GetAffordableBooks(double maxPrice)
    {
        var filtered = bookFilter.FilterByMaxPrice(allBooks, maxPrice);
        return bookSorter.SortByTitle(filtered);
    }
    public Book? GetById(int id)
    {
        return allBooks.FirstOrDefault(b => b.Id == id);
    }

    public List<Book> GetAllBooks()
    {
        return bookSorter.SortByTitle(allBooks);
    }
}