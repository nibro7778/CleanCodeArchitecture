using Order.Application.Contract;

namespace Order.Infrastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Save(Domain.Entity.Order order)
        {
            // Connect your external db and save the order details
        }
    }
}