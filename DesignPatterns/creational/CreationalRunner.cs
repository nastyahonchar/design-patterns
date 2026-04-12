using DesignPatterns.creational.abstract_factory;
using DesignPatterns.creational.builder;
using DesignPatterns.creational.factory;
using DesignPatterns.creational.factory_method;
using DesignPatterns.creational.prototype;
using DesignPatterns.creational.singleton;
using System;
using FactoryBook = DesignPatterns.creational.factory.Book;
using FactoryBookType = DesignPatterns.creational.factory.BookType;
using FMBookType = DesignPatterns.creational.factory_method.BookType;
using PrototypeBook = DesignPatterns.creational.prototype.Book;

namespace DesignPatterns.creational
{
    public class CreationalRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== CREATIONAL: SINGLETON ===");
            var manager1 = StoreManager.GetInstance();
            var manager2 = StoreManager.GetInstance();

            Console.WriteLine(manager1.GetStoreInfo());
            Console.WriteLine(manager1 == manager2); // true

            Console.WriteLine("------------------");

            Console.WriteLine("=== CREATIONAL: FACTORY ===");
            FactoryBook fBook1 = BookFactory.CreateBook(FactoryBookType.EBOOK);
            FactoryBook fBook2 = BookFactory.CreateBook(FactoryBookType.PAPER);

            Console.WriteLine(fBook1.GetDescription());
            Console.WriteLine(fBook2.GetDescription());

            Console.WriteLine("------------------");

            Console.WriteLine("=== CREATIONAL: ABSTRACT FACTORY ===");
            var factory = FactoryMaker.MakeFactory(LanguageType.UA);

            var aBook = factory.CreateBook();
            var description = factory.CreateDescription();

            Console.WriteLine(aBook.GetInfo());
            Console.WriteLine(description.GetDescription());

            Console.WriteLine("------------------");

            Console.WriteLine("=== CREATIONAL: FACTORY METHOD ===");
            BookStore onlineStore = new OnlineStore();
            var fmBook1 = onlineStore.CreateBook(FMBookType.EBOOK);

            Console.WriteLine(onlineStore);
            Console.WriteLine(fmBook1.GetInfo());

            BookStore physicalStore = new PhysicalStore();
            var fmBook2 = physicalStore.CreateBook(FMBookType.PAPER);

            Console.WriteLine(physicalStore);
            Console.WriteLine(fmBook2.GetInfo());

            Console.WriteLine("------------------");

            Console.WriteLine("=== CREATIONAL: BUILDER ===");
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

            Console.WriteLine("=== CREATIONAL: PROTOTYPE ===");
            var originalBook = new PrototypeBook("Harry Potter", 500);
            var clonedBook = (PrototypeBook)originalBook.Clone();

            Console.WriteLine(originalBook);
            Console.WriteLine(clonedBook);

            Console.WriteLine(originalBook.Equals(clonedBook)); // true
            Console.WriteLine(originalBook == clonedBook); // false

            Console.WriteLine("------------------");
        }
    }
}

