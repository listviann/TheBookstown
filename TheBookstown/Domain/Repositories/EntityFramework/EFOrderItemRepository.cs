using System.Diagnostics;
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

        public void ClearOrdersHistory(Guid userId)
        {
            foreach (var orderItem in _db.OrderItems.Where(o => o.UserId == userId))
            {
                _db.OrderItems.Remove(orderItem);
            }

            _db.SaveChanges();
        }

        public IQueryable<OrderItem> GetOrdersHistory(Guid userId)
        {
            return _db.OrderItems.Include(o => o.OrderDetails).Where(o => o.UserId == userId);
        }

        public void Save(Guid userId)
        {
            OrderItem order = new();
            order.UserId = userId;
            _db.OrderItems.Add(order);
            var cartItems = _db.UserCartItems.Include(c => c.Book);
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    BookId = item.BookId,
                    OrderId = order.Id,
                    BookTitle = item.Book!.Name,
                    Price = item.Book!.Price,
                };

                _db.OrderDetails.Add(orderDetail);
            }

            foreach (var cartItem in _db.UserCartItems.Where(c => c.UserId == userId))
            {
                _db.UserCartItems.Remove(cartItem);
            }

            _db.SaveChanges();
        }
    }
}
