using Microsoft.AspNetCore.Identity;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        IQueryable<IdentityUser> GetUsers(); 
        IdentityUser GetUserById(Guid id); 
        void Delete(Guid id);
    }
}
