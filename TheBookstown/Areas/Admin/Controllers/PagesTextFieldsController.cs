using Microsoft.AspNetCore.Mvc;
using TheBookstown.Domain;
using TheBookstown.Domain.Entities;
using TheBookstown.Service;

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

        public IActionResult Index()
        {
            return View(_dataManager.PagesTextFields.GetPageTextFields());
        }
    }
}
