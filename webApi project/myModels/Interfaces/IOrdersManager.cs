

namespace myModels.Interfaces;

public interface IOrdersManager{
void setOrder(string CustomerId, DateTime Date,decimal TotalAmount);
}