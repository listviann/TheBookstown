using Microsoft.AspNetCore.Mvc;
using TheBookstown.Areas.Admin.Controllers;
using TheBookstown.Areas.User.Controllers;
using TheBookstown.Domain;
using TheBookstown.Models;
using TheBookstown.Service;

namespace TheBookstown.Controllers
{
    public class SessionCartController : Controller
    {
        private readonly DataManager _dataManager;

        public SessionCartController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult AddToCart(Guid id)
        {
            if (User.Identity!.IsAuthenticated) return BadRequest();

            var books = _dataManager.Books.GetBooksModels();

            if (SessionHelper.GetObjectFromJson<List<SessionCartViewModel>>(HttpContext.Session, "sessionCart") == null)
            {
                List<SessionCartViewModel> cart = new List<SessionCartViewModel>()
                {
                    new SessionCartViewModel { Book = books.FirstOrDefault(b => b.BookId == id), Quantity = 1 }
                };

                SessionHelper.SetObjectAsJson(HttpContext.Session, "sessionCart", cart);
            }
            else
            {
                List<SessionCartViewModel> cart = SessionHelper.GetObjectFromJson<List<SessionCartViewModel>>(HttpContext.Session, "sessionCart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new SessionCartViewModel { Book = books.FirstOrDefault(b => b.BookId == id), Quantity = 1 });
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "sessionCart", cart);
            }

            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        public IActionResult Index()
        {
            if (User.Identity!.IsAuthenticated && User.IsInRole("ordinary"))
            {
                return RedirectToAction(nameof(UserCartController.Index), nameof(UserCartController).CutController(), new { area = "User" });
            }

            if (User.Identity!.IsAuthenticated && User.IsInRole("admin")) return BadRequest();

            var cart = SessionHelper.GetObjectFromJson<List<SessionCartViewModel>>(HttpContext.Session, "sessionCart");
            return View(cart);
        }

        public IActionResult Remove(Guid id)
        {
            if (User.Identity!.IsAuthenticated) return BadRequest();

            List<SessionCartViewModel> cart = SessionHelper.GetObjectFromJson<List<SessionCartViewModel>>(HttpContext.Session, "sessionCart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "sessionCart", cart);

            return RedirectToAction(nameof(SessionCartController.Index), nameof(SessionCartController).CutController());
        }

        private int IsExist(Guid id)
        {
            List<SessionCartViewModel> cart = SessionHelper.GetObjectFromJson<List<SessionCartViewModel>>(HttpContext.Session, "sessionCart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Book!.BookId.Equals(id))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
