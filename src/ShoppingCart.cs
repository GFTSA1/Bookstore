using Bookstore.src;
using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class ShoppingCart
    {
        public delegate void StringDelegate(string message);

        public StringDelegate? AddProductToCartDelegate;
        public event StringDelegate AddProductEvent
        {  
            add
            {
                AddProductToCartDelegate += value;
            }
            remove 
            {
                AddProductToCartDelegate -= value;
            }
        
        }

        private List<Item> _addedItemsList;

        public int TotalPrice { get; set; }
        public void addProduct(Item itemToAdd)
        {
            _addedItemsList.Add(itemToAdd);
            TotalPrice += itemToAdd.Product.Price * itemToAdd.Count;
            if (AddProductToCartDelegate != null)
            {
                AddProductToCartDelegate.Invoke("Product added to your cart:" + itemToAdd.Product.Name + " Count: " + itemToAdd.Count);
            }
        }
        public ShoppingCart()
        {
            TotalPrice = 0;
            _addedItemsList = new List<Item>();
        }
    }
}
