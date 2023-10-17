using Bookstore.src;
using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class ShoppingCart
    {
        private List<Item> _addedItemsList;

        public int TotalPrice { get; set; }
        private void addProduct(Item itemToAdd)
        {
            _addedItemsList.Add(itemToAdd);
            TotalPrice += itemToAdd.Product.Price * itemToAdd.Count;
        }
        public ShoppingCart()
        {
            TotalPrice = 0;
            _addedItemsList = new List<Item>();
        }
    }
}
