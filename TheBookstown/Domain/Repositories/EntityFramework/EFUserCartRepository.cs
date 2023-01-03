using Microsoft.EntityFrameworkCore;
using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;

namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFUserCartRepository : IUserCartRepository
    {
        private readonly AppDbContext _db;

        public EFUserCartRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Delete(Guid id)
        {
            UserCartItem cartItem = new() { Id = id };
            _db.UserCartItems.Remove(cartItem);
            _db.SaveChanges();
        }

        public IQueryable<UserCartItem> GetUserCart()
        {
            return _db.UserCartItems.Include(c => c.Book);
        }

        public UserCartItem GetUserCartItemById(Guid id)
        {
            return _db.UserCartItems.FirstOrDefault(c => c.Id == id)!;
        }

        public void Save(Guid bookId, Guid userId)
        {
            UserCartItem cartItem = new() { Id = Guid.NewGuid(), BookId = bookId, UserId = userId };
            _db.UserCartItems.Add(cartItem);
            _db.SaveChanges();
        }
    }
}
