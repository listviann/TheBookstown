using Microsoft.AspNetCore.Identity;
using TheBookstown.Domain.Repositories.Abstract;

namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFUserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public EFUserRepository(UserManager<IdentityUser> userManager, AppDbContext db)
        {
            _db = db;
            _userManager = userManager;
        }

        public void Delete(Guid id)
        {
            //_db.Users.Remove(new IdentityUser() { Id = id.ToString() });
            //_db.SaveChanges();
            _userManager.DeleteAsync(new IdentityUser() { Id = id.ToString() });
        }

        public IdentityUser GetUserById(Guid id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id.ToString())!;
        }

        public IQueryable<IdentityUser> GetUsers()
        {
            var ordinaryUsers = _userManager.GetUsersInRoleAsync("ordinary").Result;
            var ordinaryUsersIds = ordinaryUsers.Select(u => u.Id);
            var users = _db.Users.Where(u => ordinaryUsersIds.Contains(u.Id));
            return users;
        }
    }
}
