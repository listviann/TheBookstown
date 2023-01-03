using TheBookstown.Domain.Entities;

namespace TheBookstown.Models
{
    public class AuthorsIndexViewModel
    {
        public IEnumerable<Author> Authors { get; }
        public PageViewModel PageViewModel { get; }
        public AuthorsSortViewModel SortViewModel { get; }
        public AuthorsFilterViewModel FilterViewModel { get; }

        public AuthorsIndexViewModel(IEnumerable<Author> authors, PageViewModel pageViewModel, AuthorsSortViewModel sortViewModel, AuthorsFilterViewModel filterViewModel)
        {
            Authors = authors;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}
