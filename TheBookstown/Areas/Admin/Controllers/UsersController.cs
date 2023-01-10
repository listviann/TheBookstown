using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheBookstown.Areas.Admin.Models;
using TheBookstown.Domain;
using TheBookstown.Service;
using TheBookstown.Models;

namespace TheBookstown.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly DataManager _dataManager;

        public UsersController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.Users.Delete(id);
            return RedirectToAction(nameof(UsersController.Index), nameof(UsersController).CutController());
        }

        public IActionResult Index(Guid id, string userName, int page = 1, UsersSortState sortOrder = UsersSortState.UserNameAsc)
        {
            if (id != default) return View("Info", _dataManager.Users.GetUserById(id));

            int pageSize = 3;
            IQueryable<IdentityUser> users = _dataManager.Users.GetUsers();

            if (!string.IsNullOrWhiteSpace(userName))
            {
                users = users.Where(u => u.UserName.Contains(userName));
            }

            users = sortOrder switch
            {
                UsersSortState.UserNameDesc => users.OrderByDescending(u => u.UserName),
                _ => users.OrderBy(u => u.UserName)
            };

            var count = users.Count();
            var items = users.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new UsersIndexViewModel(users,
                new PageViewModel(count, page, pageSize),
                new UsersSortViewModel(sortOrder),
                new UsersFilterViewModel(userName));

            return View(viewModel);
        }
    }
}
