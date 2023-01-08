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

        public IActionResult Index(Guid id, string bookName, string authorName, Guid genre, int page = 1, BooksSortState sortOrder = BooksSortState.BookNameAsc)
        {
            if (id != default) return View("Info", _dataManager.Books.GetBookById(id));

            int pageSize = 3;
            IEnumerable<BookViewModel> books = _dataManager.Books.GetBooksModels();

            if (!string.IsNullOrWhiteSpace(bookName))
            {
                books = books.Where(b => b.BookName!.Contains(bookName));
            }
            if (!string.IsNullOrWhiteSpace(authorName))
            {
                books = books.Where(b => b.BookAuthorName!.Contains(authorName));
            }
            if (genre != default)
            {
                books = books.Where(b => b.BookGenreId == genre);
            }

            books = sortOrder switch
            {
                BooksSortState.BooksNameDesc => books.OrderByDescending(b => b.BookName),
                BooksSortState.PriceAsc => books.OrderBy(b => b.BookPrice),
                BooksSortState.PriceDesc => books.OrderByDescending(b => b.BookPrice),
                _ => books.OrderBy(b => b.BookName)
            };

            var count = books.Count();
            var items = books.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            BooksIndexViewModel viewModel = new(items, 
                new PageViewModel(count, page, pageSize),
                new BooksSortViewModel(sortOrder), 
                new BooksFilterViewModel(_dataManager.Genres.GetGenres().ToList(), genre, 
                    bookName, authorName));

            
            ViewBag.PageTextField = _dataManager.PagesTextFields.GetPageTextFieldByCodeWord("Home");
            return View(viewModel);
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