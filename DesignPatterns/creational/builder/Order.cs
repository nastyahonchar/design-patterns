using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.builder
{
    public class Order
    {
        public string CustomerName { get; }
        public int BookCount { get; }
        public DeliveryType Delivery { get; }
        public PaymentType Payment { get; }
        public OrderStatus Status { get; }
        public string Comment { get; }

        private Order(Builder builder)
        {
            CustomerName = builder.CustomerName;
            BookCount = builder.BookCount;
            Delivery = builder.Delivery;
            Payment = builder.Payment;
            Status = builder.Status;
            Comment = builder.Comment;
        }

        public override string ToString()
        {
            return $"Order: {CustomerName}, Books: {BookCount}, " +
                   $"Delivery: {Delivery.ToString().ToLower()}, " +
                   $"Payment: {Payment.ToString().ToLower()}, " +
                   $"Status: {Status.ToString().ToLower()}, " +
                   $"Comment: {Comment}";
        }

        public class Builder
        {
            public string CustomerName { get; }
            public int BookCount { get; }

            public DeliveryType Delivery { get; private set; }
            public PaymentType Payment { get; private set; }
            public OrderStatus Status { get; private set; }
            public string Comment { get; private set; }

            public Builder(string customerName, int bookCount)
            {
                if (customerName == null)
                    throw new ArgumentException("Customer name cannot be null");

                CustomerName = customerName;
                BookCount = bookCount;
            }

            public Builder WithDelivery(DeliveryType delivery)
            {
                Delivery = delivery;
                return this;
            }

            public Builder WithPayment(PaymentType payment)
            {
                Payment = payment;
                return this;
            }

            public Builder WithStatus(OrderStatus status)
            {
                Status = status;
                return this;
            }

            public Builder WithComment(string comment)
            {
                Comment = comment;
                return this;
            }

            public Order Build()
            {
                return new Order(this);
            }
        }
    }
}
