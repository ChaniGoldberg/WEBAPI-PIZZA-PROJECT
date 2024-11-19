using Microsoft.AspNetCore.Mvc;
using תשתית_לניהול_חנות_פיצה_חני_גולדברג;

public interface IOrdersManager{
void setOrder(string CustomerId, DateTime Date,decimal TotalAmount);
}