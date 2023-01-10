using Microsoft.AspNetCore.Mvc;
using TheBookstown.Areas.Admin.Models;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Service;
using TheBookstown.Models;

namespace TheBookstown.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesTextFieldsController : Controller
    {
        private readonly DataManager _dataManager;

        public PagesTextFieldsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Edit(string codeWord)
        {
            var entity = _dataManager.PagesTextFields.GetPageTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(PageTextField entity)
        {
            if (ModelState.IsValid)
            {
                _dataManager.PagesTextFields.SavePageTextField(entity);
                return RedirectToAction(nameof(PagesTextFieldsController.Index), nameof(PagesTextFieldsController).CutController());
            }

            return View(entity);
        }

        public IActionResult Index(Guid id, string pageTitle, string codeWord, int page = 1, PTFSortState sortOrder = PTFSortState.CodeWordAsc)
        {
            int pageSize = 3;
            IQueryable<PageTextField> pageTextFields = _dataManager.PagesTextFields.GetPageTextFields();
            
            if (!string.IsNullOrWhiteSpace(codeWord))
            {
                pageTextFields = pageTextFields.Where(p => p.CodeWord!.Contains(codeWord));
            }

            if (!string.IsNullOrWhiteSpace(pageTitle))
            {
                pageTextFields = pageTextFields.Where(p => p.Name!.Contains(pageTitle));
            }

            pageTextFields = sortOrder switch
            {
                PTFSortState.CodeWordDesc => pageTextFields.OrderByDescending(p => p.CodeWord),
                PTFSortState.TitleAsc => pageTextFields.OrderBy(p => p.Name),
                PTFSortState.TitleDesc => pageTextFields.OrderByDescending(p => p.Name),
                _ => pageTextFields.OrderBy(p => p.CodeWord)
            };

            var count = pageTextFields.Count();
            var items = pageTextFields.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new PTFIndexViewModel(items,
                new PageViewModel(count, page, pageSize),
                new PTFSortViewModel(sortOrder),
                new PTFFilterViewModel(pageTitle, codeWord));

            return View(viewModel);
        }
    }
}
