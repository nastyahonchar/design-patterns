using DesignPatterns.structural.adapter;
using DesignPatterns.structural.bridge;
using DesignPatterns.structural.composite;
using DesignPatterns.structural.decorator;
using DesignPatterns.structural.facade;
using DesignPatterns.structural.flyweight;
using DesignPatterns.structural.proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeBook = DesignPatterns.structural.bridge.Book;
using CompositeBook = DesignPatterns.structural.composite.Book;
using FlyweightBookStore = DesignPatterns.structural.flyweight.BookStore;
using FlyweightIBook = DesignPatterns.structural.flyweight.IBook;
using DecoratorIBook = DesignPatterns.structural.decorator.IBook;

namespace DesignPatterns.structural
{
    public class StructuralRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== STRUCTURAL: ADAPTER ===");

            IDelivery delivery = new CourierDeliveryAdapter();
            var processor = new OrderProcessor(delivery);

            processor.ProcessOrder();

            Console.WriteLine("------------------");

            Console.WriteLine("=== STRUCTURAL: COMPOSITE ===");

            var fiction = new Category("Fiction");
            fiction.Add(new CompositeBook("Harry Potter", "J.K. Rowling"));
            fiction.Add(new CompositeBook("Lord of the Rings", "J.R.R. Tolkien"));

            var nonFiction = new Category("Non-Fiction");
            nonFiction.Add(new CompositeBook("Sapiens", "Yuval Noah Harari"));

            var catalog = new Category("Horror");
            catalog.Add(fiction);
            catalog.Add(nonFiction);

            catalog.Print();

            Console.WriteLine("------------------");

            Console.WriteLine("=== STRUCTURAL: PROXY ===");

            var premiumUsers = new HashSet<string> { "Alice", "Bob" };
            IBookStore store = new BookStoreProxy(premiumUsers);

            store.ViewBook("Alice", "Harry Potter");
            store.ViewBook("Bob", "Lord of the Rings");
            store.ViewBook("Charlie", "Sapiens");

            Console.WriteLine("------------------");

            Console.WriteLine("=== STRUCTURAL: FLYWEIGHT ===");

            var factory = new BookFactory();

            var shop = new FlyweightBookStore(
                new List<FlyweightIBook>
                {
                    factory.CreateBook(BookType.EBOOK),
                    factory.CreateBook(BookType.EBOOK),
                    factory.CreateBook(BookType.PAPER)
                },
                new List<FlyweightIBook>
                {
                    factory.CreateBook(BookType.PAPER),
                    factory.CreateBook(BookType.AUDIO),
                    factory.CreateBook(BookType.AUDIO)
                }
            );

            shop.ReadBooks();

            Console.WriteLine("------------------");

            Console.WriteLine("=== STRUCTURAL: FACADE ===");

            var facade = new OrderFacade();
            facade.PlaceOrder();

            Console.WriteLine("------------------");

            Console.WriteLine("=== STRUCTURAL: BRIDGE ===");

            BridgeBook book1 = new FantasyBook(new EbookFormat());
            book1.Open();
            book1.Read();
            book1.Close();

            Console.WriteLine();

            BridgeBook book2 = new ScienceBook(new PaperFormat());
            book2.Open();
            book2.Read();
            book2.Close();

            Console.WriteLine("------------------");

            Console.WriteLine("=== STRUCTURAL: DECORATOR ===");

            DecoratorIBook book = new SimpleBook();

            book = new SpecialBook(book);

            book = new DiscountBook(book);

            book.GetDescription();
            Console.WriteLine("Price: " + book.GetPrice());

            Console.WriteLine("------------------");
        }
    }
}
