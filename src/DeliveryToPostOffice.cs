﻿using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class DeliveryToPostOffice : IDelivery
    {
        public int OfficeNumber { get; set; }
        public deliveryCompaines DeliveryCompany {get; set; }
    }
}
