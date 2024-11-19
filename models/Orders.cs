using System;
using System.Collections.Generic;

using תשתית_לניהול_חנות_פיצה_חני_גולדברג;

namespace OrderManagement.Models
{
    public class Orders
    {
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        public Orders(string _CustomerId,DateTime _Date,decimal _TotalAmount)
        {
            CustomerId=_CustomerId;
            Date=_Date;
            TotalAmount=_TotalAmount;
        }
    }
}