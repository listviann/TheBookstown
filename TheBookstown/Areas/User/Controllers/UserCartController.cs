using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBookstown.Areas.Admin.Controllers;
using TheBookstown.Domain;
using TheBookstown.Service;

namespace TheBookstown.Areas.User.Controllers
{
    [Area("User")]
    public class UserCartController : Controller
    {
        private readonly DataManager _dataManager;

        public UserCartController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.UserCartItems.GetUserCart());
        }

        [HttpPost]
        public IActionResult Add(Guid bookId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.userId = new Guid(userId);
            _dataManager.UserCartItems.Save(bookId, new Guid(userId));
            return RedirectToAction(nameof(TheBookstown.Controllers.HomeController.Index), nameof(TheBookstown.Controllers.HomeController).CutController());
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.UserCartItems.Delete(id);
            return RedirectToAction(nameof(UserCartController.Index), nameof(UserCartController).CutController());
        }
    }
}
