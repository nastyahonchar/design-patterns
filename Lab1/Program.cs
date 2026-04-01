using Lab1.creational.abstract_factory;
using Lab1.creational.builder;
using Lab1.creational.factory;
using Lab1.creational.factory_method;
using Lab1.creational.prototype;
using Lab1.creational.singleton;
using System;
using FactoryBook = Lab1.creational.factory.Book;
using FactoryBookType = Lab1.creational.factory.BookType;
using FMBookType = Lab1.creational.factory_method.BookType;
using PrototypeBook = Lab1.creational.prototype.Book;

class Program
{
    static void Main(string[] args)
    {
        // Singleton
        var manager1 = StoreManager.GetInstance();
        var manager2 = StoreManager.GetInstance();

        Console.WriteLine(manager1.GetStoreInfo());
        Console.WriteLine(manager1 == manager2); // true

        Console.WriteLine("------------------");

        // Factory
        FactoryBook fBook1 = BookFactory.CreateBook(FactoryBookType.EBOOK);
        FactoryBook fBook2 = BookFactory.CreateBook(FactoryBookType.PAPER);

        Console.WriteLine(fBook1.GetDescription());
        Console.WriteLine(fBook2.GetDescription());

        Console.WriteLine("------------------");

        // Abstract Factory
        var factory = FactoryMaker.MakeFactory(LanguageType.UA);

        var aBook = factory.CreateBook();
        var description = factory.CreateDescription();

        Console.WriteLine(aBook.GetInfo());
        Console.WriteLine(description.GetDescription());

        Console.WriteLine("------------------");

        // Factory Method
        BookStore onlineStore = new OnlineStore();
        var fmBook1 = onlineStore.CreateBook(FMBookType.EBOOK);

        Console.WriteLine(onlineStore);
        Console.WriteLine(fmBook1.GetInfo());

        BookStore physicalStore = new PhysicalStore();
        var fmBook2 = physicalStore.CreateBook(FMBookType.PAPER);

        Console.WriteLine(physicalStore);
        Console.WriteLine(fmBook2.GetInfo());

        Console.WriteLine("------------------");

        // Builder
        var order1 = new Order.Builder("Nastya", 3)
            .WithDelivery(DeliveryType.COURIER)
            .WithPayment(PaymentType.CARD)
            .WithStatus(OrderStatus.PROCESSING)
            .WithComment("Call before delivery")
            .Build();

        Console.WriteLine(order1);

        var order2 = new Order.Builder("Andrew", 1)
            .WithDelivery(DeliveryType.PICKUP)
            .WithPayment(PaymentType.CASH)
            .WithStatus(OrderStatus.CREATED)
            .Build();

        Console.WriteLine(order2);

        Console.WriteLine("------------------");

        // Prototype
        var originalBook = new PrototypeBook("Harry Potter", 500);
        var clonedBook = (PrototypeBook)originalBook.Clone();

        Console.WriteLine(originalBook);
        Console.WriteLine(clonedBook);

        Console.WriteLine(originalBook.Equals(clonedBook)); // true
        Console.WriteLine(originalBook == clonedBook); // false
    }
}
