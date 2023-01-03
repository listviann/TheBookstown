using TheBookstown.Domain.Entities;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IOrderItemRepository
    {
        void Save(Guid userId);
        IQueryable<OrderItem> GetOrdersHistory();
        void ClearOrdersHistory();
    }
}
