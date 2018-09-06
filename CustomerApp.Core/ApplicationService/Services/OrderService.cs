using System.Collections.Generic;
using System.Linq;
using CustomerApp.Core.DomainService;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.ApplicationService.Services
{
    public class OrderService: IOrderService
    {
        private IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }
        
        public Order New()
        {
            return new Order();
        }

        public Order CreateOrder(Order order)
        {
            return _repository.Create(order);
        }

        public Order FindOrderById(int id)
        {
            return _repository.ReadyById(id);
        }

        public List<Order> GetAllOrders()
        {
            return _repository.ReadAll().ToList();
        }

        public Order UpdateOrder(Order orderUpdate)
        {
            return _repository.Update(orderUpdate);
        }

        public Order DeleteOrder(int id)
        {
            return _repository.Delete(id);
        }
    }
}