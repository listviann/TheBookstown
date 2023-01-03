using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Models;

namespace TheBookstown.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly DataManager _dataManager;

        public AuthorsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index(Guid id, string name, int page = 1, AuthorsSortState sortOrder = AuthorsSortState.AuthorNameAsc)
        {
            if (id != default) return View("Info", _dataManager.Authors.GetAuthorById(id));

            int pageSize = 3;
            IQueryable<Author> authors = _dataManager.Authors.GetAuthors();

            if (!string.IsNullOrWhiteSpace(name))
            {
                authors = authors.Where(a => a.Name!.Contains(name));
            }

            authors = sortOrder switch
            {
                AuthorsSortState.AuthorNameDesc => authors.OrderByDescending(a => a.Name),
                _ => authors.OrderBy(a => a.Name)
            };

            var count = authors.Count();
            var items = authors.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new AuthorsIndexViewModel(items, new PageViewModel(count, page, pageSize),
                new AuthorsSortViewModel(sortOrder), new AuthorsFilterViewModel(name));

            return View(viewModel);
        }
    }
}
