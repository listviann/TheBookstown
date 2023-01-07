namespace TheBookstown.Models
{
    public enum BooksSortState
    {
        BookNameAsc,
        BooksNameDesc,
        PriceAsc,
        PriceDesc
    }

    public class BooksSortViewModel
    {
        public BooksSortState NameSort { get; }
        public BooksSortState PriceSort { get; }
        public BooksSortState Current { get; }

        public BooksSortViewModel(BooksSortState sortOrder)
        {
            NameSort = sortOrder == BooksSortState.BookNameAsc ? BooksSortState.BooksNameDesc : BooksSortState.BookNameAsc;
            PriceSort = sortOrder == BooksSortState.PriceAsc ? BooksSortState.PriceDesc : BooksSortState.PriceAsc;
            Current = sortOrder;
        }
    }
}
