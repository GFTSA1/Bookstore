﻿using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class DeliveryByCurier : IDelivery
    {
        public String Address { get; set; }
        public deliveryCompaines DeliveryCompany { get; set; }


    }
}
