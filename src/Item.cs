using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.src
{
    public class Item
    {
        public IProduct Product { get; set; }
        public int Count {  get; set; }

        public Item(IProduct product, int count) 
        {
            Product = product;
            Count = count; 
        }
    }
}
