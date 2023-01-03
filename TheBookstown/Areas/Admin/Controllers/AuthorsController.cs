using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Service;

namespace TheBookstown.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        private readonly DataManager _dataManager;

        public AuthorsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Author() : _dataManager.Authors.GetAuthorById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Author entity)
        {
            if (ModelState.IsValid)
            {
                _dataManager.Authors.Save(entity);
                return RedirectToAction(nameof(TheBookstown.Controllers.AuthorsController.Index), nameof(TheBookstown.Controllers.AuthorsController).CutController());
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.Authors.Delete(id);
            return RedirectToAction(nameof(TheBookstown.Controllers.AuthorsController.Index), nameof(TheBookstown.Controllers.AuthorsController).CutController());
        }
    }
}
