using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
namespace תשתית_לניהול_חנות_פיצה_חני_גולדברג.Controllers;
public class OrdersController : BaceController
{
    IOrdersManager _OrderServices;
        public OrdersController(IOrdersManager order)
      {
            _OrderServices = order;
      } 
      [Route("[action]/{CustomerId}/{Date}/{TotalAmount}/{Items}")]
      [HttpPost]
      public IActionResult setPizza(string CustomerId, DateTime Date,decimal TotalAmount)
      {
            _OrderServices.setOrder(CustomerId,Date,TotalAmount);
            return Created();
      }
}