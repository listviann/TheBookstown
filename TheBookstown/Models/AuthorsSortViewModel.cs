namespace TheBookstown.Models
{
    public enum AuthorsSortState
    {
        AuthorNameAsc,
        AuthorNameDesc
    }

    public class AuthorsSortViewModel
    {
        public AuthorsSortState NameSort { get; }
        public AuthorsSortState Current { get; }

        public AuthorsSortViewModel(AuthorsSortState sortOrder)
        {
            NameSort = sortOrder == AuthorsSortState.AuthorNameAsc ? AuthorsSortState.AuthorNameDesc : AuthorsSortState.AuthorNameAsc;
            Current = sortOrder;
        }
    }
}
