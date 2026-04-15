using DesignPatterns.behavioral.chain_of_responsibility;
using DesignPatterns.behavioral.command;
using DesignPatterns.behavioral.iterator;
using DesignPatterns.behavioral.mediator;
using DesignPatterns.behavioral.mediator.members;
using DesignPatterns.behavioral.memento;
using DesignPatterns.behavioral.observer;
using DesignPatterns.behavioral.state;
using DesignPatterns.behavioral.strategy;
using DesignPatterns.behavioral.template_method;
using DesignPatterns.behavioral.visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorCustomer = DesignPatterns.behavioral.mediator.members.Customer;
using MementoOrder = DesignPatterns.behavioral.memento.Order;
using ObserverBook = DesignPatterns.behavioral.observer.Book;
using StateOrder = DesignPatterns.behavioral.state.Order;
using StrategyOrder = DesignPatterns.behavioral.strategy.Order;
using TemplateCustomer = DesignPatterns.behavioral.template_method.Customer;
using VisitorBook = DesignPatterns.behavioral.visitor.Book;
using IteratorBook = DesignPatterns.behavioral.iterator.Book;

namespace DesignPatterns.behavioral
{
    public class BehavioralRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== BEHAVIORAL: TEMPLATE METHOD ===");

            var templateCustomer = new TemplateCustomer(new OnlineOrder());

            Console.WriteLine("Online order:");
            templateCustomer.MakeOrder();

            Console.WriteLine("\nSwitching to pickup:\n");

            templateCustomer.ChangeOrderProcess(new PickupOrder());
            templateCustomer.MakeOrder();

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: MEDIATOR ===");

            var mediator = new OrderMediator();

            var mediatorCustomer = new MediatorCustomer();
            var warehouse = new Warehouse();
            var delivery = new Delivery();

            mediator.AddMember(mediatorCustomer);
            mediator.AddMember(warehouse);
            mediator.AddMember(delivery);

            Console.WriteLine("\nCustomer creates order:\n");
            mediatorCustomer.Send(OrderAction.ORDER_CREATED);

            Console.WriteLine("\nWarehouse prepares book:\n");
            warehouse.Send(OrderAction.BOOK_PREPARED);

            Console.WriteLine("\nDelivery ships order:\n");
            delivery.Send(OrderAction.ORDER_SHIPPED);

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: CHAIN OF RESPONSIBILITY ===");

            var manager = new StoreManager(new List<IRequestHandler>
            {
                new PaymentService(),
                new DeliveryService(),
                new SupportService()
            });

            Console.WriteLine("Payment request:");
            manager.Process(new Request(RequestType.PAYMENT, "Pay for order"));

            Console.WriteLine("\nDelivery request:");
            manager.Process(new Request(RequestType.DELIVERY, "Deliver book"));

            Console.WriteLine("\nReturn request:");
            manager.Process(new Request(RequestType.RETURN, "Return damaged book"));

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: OBSERVER ===");

            var observerBook = new ObserverBook();

            var user1 = new User("Anna");
            var user2 = new User("Ivan");

            observerBook.Subscribe(user1);
            observerBook.Subscribe(user2);

            Console.WriteLine("\nFirst change:");
            observerBook.ChangeStatus();

            Console.WriteLine("\nSecond change:");
            observerBook.ChangeStatus();

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: STRATEGY ===");

            var strategyOrder = new StrategyOrder(new CardPayment());

            Console.WriteLine("Card payment:");
            strategyOrder.Checkout(500);

            Console.WriteLine("\nSwitch to cash:\n");

            strategyOrder.ChangeStrategy(new CashPayment());
            strategyOrder.Checkout(500);

            Console.WriteLine("\nSwitch to PayPal:\n");

            strategyOrder.ChangeStrategy(new PayPalPayment());
            strategyOrder.Checkout(500);

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: COMMAND ===");

            var creator = new OrderCreator();
            var canceler = new OrderCanceler();

            var placeCommand = new CreateOrderCommand(creator);
            var cancelCommand = new CancelOrderCommand(canceler);

            var invoker = new OrderInvoker(placeCommand);

            Console.WriteLine("Placing order:");
            invoker.Invoke();

            Console.WriteLine("\nCanceling order:\n");

            invoker.SetCommand(cancelCommand);
            invoker.Invoke();

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: STATE ===");

            var stateOrder = new StateOrder();

            Console.WriteLine("Initial state:");
            stateOrder.Handle();

            Console.WriteLine("\nChange state:\n");
            stateOrder.NextState();
            stateOrder.Handle();

            Console.WriteLine("\nChange state again:\n");
            stateOrder.NextState();
            stateOrder.Handle();

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: VISITOR ===");

            var books = new List<VisitorBook>
            {
                new FictionBook("Harry Potter", 100),
                new ScienceBook("Physics 101", 200),
                new HistoryBook("World War II", 150)
            };

            Console.WriteLine("Discount:");
            var discount = new DiscountVisitor();
            foreach (var b in books) b.Accept(discount);

            Console.WriteLine("\nAvailability:");
            var availability = new AvailabilityVisitor();
            foreach (var b in books) b.Accept(availability);

            Console.WriteLine("\nDescription:");
            var description = new DescriptionVisitor();
            foreach (var b in books) b.Accept(description);

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: ITERATOR ===");

            var catalog = new Catalog(new List<IteratorBook>
            {
                new IteratorBook(Genre.FICTION, "Harry Potter"),
                new IteratorBook(Genre.SCIENCE, "Quantum Physics"),
                new IteratorBook(Genre.HISTORY, "World War II"),
                new IteratorBook(Genre.FICTION, "Lord of the Rings")
            });

            Console.WriteLine("\nAll books:");

            var allIterator = catalog.GetIterator(Genre.ANY);

            while (allIterator.HasNext())
            {
                Console.WriteLine(allIterator.Next());
            }

            Console.WriteLine("\nFiction books:");

            var fictionIterator = catalog.GetIterator(Genre.FICTION);

            while (fictionIterator.HasNext())
            {
                Console.WriteLine(fictionIterator.Next());
            }

            Console.WriteLine("------------------");

            Console.WriteLine("=== BEHAVIORAL: MEMENTO ===");

            var mementoOrder = new MementoOrder(OrderStatus.NEW, 100);
            var history = new OrderHistory();

            Console.WriteLine(mementoOrder);

            history.Save(mementoOrder.Save());

            mementoOrder.Update(OrderStatus.PAID, 100);
            Console.WriteLine("\nAfter payment:");
            Console.WriteLine(mementoOrder);

            history.Save(mementoOrder.Save());

            mementoOrder.Update(OrderStatus.SHIPPED, 100);
            Console.WriteLine("\nAfter shipping:");
            Console.WriteLine(mementoOrder);

            Console.WriteLine("\nUndo:");
            mementoOrder.Restore(history.Undo());
            Console.WriteLine(mementoOrder);

            Console.WriteLine("\nUndo again:");
            mementoOrder.Restore(history.Undo());
            Console.WriteLine(mementoOrder);

            Console.WriteLine("------------------");
        }
    }
}
