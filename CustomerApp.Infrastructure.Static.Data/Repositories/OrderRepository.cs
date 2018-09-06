using System.Collections.Generic;
using System.Linq;
using CustomerApp.Core.DomainService;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Static.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Order Create(Order order)
        {
            order.Id = FakeDB.OrderId++;
            FakeDB.Orders.Add(order);
            return order;
        }

        public Order ReadyById(int id)
        {
            return FakeDB.Orders.FirstOrDefault(order => order.Id == id);
        }

        public IEnumerable<Order> ReadAll()
        {
            return FakeDB.Orders;
        }

        public Order Update(Order orderUpdate)
        {
            var orderFromDB = ReadyById(orderUpdate.Id);
            if (orderFromDB == null) return null;
            
            orderFromDB.DeliveryDate = orderUpdate.DeliveryDate;
            orderFromDB.OrderDate = orderUpdate.OrderDate;
            if (orderUpdate.Customer != null && orderFromDB.Customer != null)
            {
                orderFromDB.Customer.Id = orderUpdate.Customer.Id;
            }
            return orderFromDB;
        }

        public Order Delete(int id)
        {
            var orderFound = ReadyById(id);
            if (orderFound == null) return null;
            
            FakeDB.Orders.Remove(orderFound);
            return orderFound;
        }
    }
}