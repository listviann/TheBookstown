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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.PageTextField = _dataManager.PagesTextFields.GetPageTextFieldByCodeWord("Orders");
            
            return View(_dataManager.OrderItems.GetOrdersHistory(new Guid(userId!)));
        }

        [HttpPost]
        public IActionResult DoOrder()
        {
            if (_dataManager.UserCartItems.GetUserCart() == null) return BadRequest();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _dataManager.OrderItems.Save(new Guid(userId!));
            return RedirectToAction(nameof(TheBookstown.Controllers.HomeController.Index), nameof(TheBookstown.Controllers.HomeController).CutController(), new { area = "" });
        }

        [HttpPost]
        public IActionResult ClearHistory()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (_dataManager.OrderItems.GetOrdersHistory(new Guid(userId!)) == null) return BadRequest();
            _dataManager.OrderItems.ClearOrdersHistory(new Guid(userId!));
            return RedirectToAction(nameof(OrdersController.Index), nameof(OrdersController).CutController());
        }
    }
}
