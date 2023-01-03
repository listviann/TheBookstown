using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Service;

namespace TheBookstown.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenresController : Controller
    {
        private readonly DataManager _dataManager;
        
        public GenresController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Genre() : _dataManager.Genres.GetGenreById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Genre entity)
        {
            if (ModelState.IsValid)
            {
                _dataManager.Genres.Save(entity);
                return RedirectToAction(nameof(GenresController.Index), nameof(GenresController).CutController());
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.Genres.Delete(id);
            return RedirectToAction(nameof(GenresController.Index), nameof(GenresController).CutController());
        }

        public IActionResult Index()
        {
            return View(_dataManager.Genres.GetGenres());
        }
    }
}
