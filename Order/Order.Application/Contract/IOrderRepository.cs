namespace Order.Application.Contract
{
    public interface IOrderRepository
    {
        void Save(Domain.Entity.Order order);
    }
}