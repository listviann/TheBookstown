namespace TheBookstown.Areas.Admin.Models
{
    public enum GenresSortState
    {
        GenreNameAsc,
        GenreNameDesc
    }

    public class GenresSortViewModel
    {
        public GenresSortState NameSort { get; }
        public GenresSortState Current { get; }

        public GenresSortViewModel(GenresSortState sortOrder)
        {
            NameSort = sortOrder == GenresSortState.GenreNameAsc ? GenresSortState.GenreNameDesc : GenresSortState.GenreNameAsc;
            Current = sortOrder;
        }
    }
}
