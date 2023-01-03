using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBookstown.Domain;
using TheBookstown.Service;

namespace TheBookstown.Areas.User.Controllers
{
    [Area("User")]
    public class OrdersController : Controller
    {
        private readonly DataManager _dataManager;

        public OrdersController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.OrderItems.GetOrdersHistory());
        }

        [HttpPost]
        public IActionResult DoOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _dataManager.OrderItems.Save(new Guid(userId));
            return RedirectToAction(nameof(TheBookstown.Controllers.HomeController.Index), nameof(TheBookstown.Controllers.HomeController).CutController());
        }

        [HttpPost]
        public IActionResult ClearHistory()
        {
            _dataManager.OrderItems.ClearOrdersHistory();
            return RedirectToAction(nameof(OrdersController.Index), nameof(OrdersController).CutController());
        }
    }
}
