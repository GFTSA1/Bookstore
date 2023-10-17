using Bookstore.src;
using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public enum orderStatus { pending, done, deliveryInProgress, notPaid}
    class Order
    {
        
        public Client Client {  get; set; }
        public IDelivery Delivery { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public orderStatus Status { get; set; }
        public Order(Client client, IDelivery delivery )
        {
            Status = orderStatus.pending;
            Client = client;
            Delivery = delivery;
            ShoppingCart = new ShoppingCart();
        }


    }
}
