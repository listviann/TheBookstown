using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Service;

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

        public IActionResult Index(Guid id)
        {
            if (id != default) return View("Info", _dataManager.Users.GetUserById(id));
            return View(_dataManager.Users.GetUsers());
        }
    }
}
