using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Service;

namespace TheBookstown.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly DataManager _dataManager;

        public BooksController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Book() : _dataManager.Books.GetBookById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Book entity)
        {
            if (ModelState.IsValid)
            {
                _dataManager.Books.Save(entity);
                return RedirectToAction(nameof(TheBookstown.Controllers.HomeController.Index), nameof(TheBookstown.Controllers.HomeController).CutController());
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.Books.Delete(id);
            return RedirectToAction(nameof(TheBookstown.Controllers.HomeController.Index), nameof(TheBookstown.Controllers.HomeController).CutController());
        }
    }
}
