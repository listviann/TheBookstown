using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;

namespace TheBookstown.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly DataManager _dataManager;

        public AuthorsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default) return View("Info", _dataManager.Authors.GetAuthorById(id));
            return View(_dataManager.Authors.GetAuthors());
        }
    }
}
