using TheBookstown.Domain.Entities;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IUserCartRepository
    {
        IQueryable<UserCartItem> GetUserCart();
        UserCartItem GetUserCartItemById(Guid id);
        void Save(Guid bookId, Guid userId);
        void Delete(Guid id);
    }
}
