using Microsoft.DiaSymReader;
using Microsoft.EntityFrameworkCore;
using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;


namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFOrderItemRepository : IOrderItemRepository
    {
        private readonly AppDbContext _db;

        public EFOrderItemRepository(AppDbContext db)
        {
            _db = db;
        }

        public void ClearOrdersHistory()
        {
            foreach (var orderItem in _db.OrderItems)
            {
                _db.OrderItems.Remove(orderItem);
            }

            _db.SaveChanges();
        }

        public IQueryable<OrderItem> GetOrdersHistory()
        {
            return _db.OrderItems;
        }

        public void Save(Guid userId)
        {
            int totalCost = 0;
            OrderItem order = new() { Id = Guid.NewGuid(), UserId = userId };
            foreach (var item in _db.UserCartItems.Include(c => c.Book).ToList())
            {
                order.CartItems.Add(item);
                totalCost += item.Book!.Price;
            }

            order.TotalCost = totalCost;

            foreach (var cartItem in _db.UserCartItems)
            {
                _db.UserCartItems.Remove(cartItem);
            }

            _db.SaveChanges();
        }
    }
}
