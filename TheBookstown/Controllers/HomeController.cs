using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Models;

namespace TheBookstown.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default) return View("Info", _dataManager.Books.GetBookById(id));
            ViewBag.PageTextField = _dataManager.PagesTextFields.GetPageTextFieldByCodeWord("Home");
            return View(_dataManager.Books.GetBooks());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}