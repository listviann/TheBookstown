using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using TheBookstown.Areas.Admin.Models;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Models;
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

        public IActionResult Index(Guid id, string genreName, int page = 1, GenresSortState sortOrder = GenresSortState.GenreNameAsc)
        {
            int pageSize = 3;
            IQueryable<Genre> genres = _dataManager.Genres.GetGenres();

            if (!string.IsNullOrWhiteSpace(genreName))
            {
                genres = genres.Where(g => g.Name!.Contains(genreName));
            }

            genres = sortOrder switch
            {
                GenresSortState.GenreNameDesc => genres.OrderByDescending(g => g.Name),
                _ => genres.OrderBy(g => g.Name)
            };

            var count = genres.Count();
            var items = genres.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new GenresIndexViewModel(items, 
                new PageViewModel(count, page, pageSize),
                new GenresSortViewModel(sortOrder),
                new GenresFilterViewModel(genreName));

            return View(viewModel);
        }
    }
}
