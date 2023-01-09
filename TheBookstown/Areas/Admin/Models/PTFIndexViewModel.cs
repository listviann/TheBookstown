using TheBookstown.Domain.Entities;
using TheBookstown.Models;

namespace TheBookstown.Areas.Admin.Models
{
    public class PTFIndexViewModel
    {
        public IEnumerable<PageTextField> PagesTextFields { get; }
        public PageViewModel PageViewModel { get; }
        public PTFSortViewModel SortViewModel { get; }
        public PTFFilterViewModel FilterViewModel { get; }

        public PTFIndexViewModel(IEnumerable<PageTextField> pagesTextFields, PageViewModel pageViewModel,
            PTFSortViewModel sortViewModel, PTFFilterViewModel filterViewModel)
        {
            PagesTextFields = pagesTextFields;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}
