namespace TheBookstown.Models
{
    public class BooksIndexViewModel
    {
        public IEnumerable<BookViewModel> Books { get; }
        public PageViewModel PageViewModel { get; }
        public BooksSortViewModel SortViewModel { get; }
        public BooksFilterViewModel FilterViewModel { get; }

        public BooksIndexViewModel(IEnumerable<BookViewModel> books, PageViewModel pageViewModel, BooksSortViewModel sortViewModel, BooksFilterViewModel filterViewModel)
        {
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
            Books = books;
        }
    }
}
