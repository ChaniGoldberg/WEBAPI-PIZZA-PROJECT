using System;
using System.Collections.Generic;



namespace myModels;

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
