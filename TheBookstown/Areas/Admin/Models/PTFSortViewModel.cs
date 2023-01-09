namespace TheBookstown.Areas.Admin.Models
{
    public enum PTFSortState
    {
        TitleAsc,
        TitleDesc,
        CodeWordAsc,
        CodeWordDesc,
    }

    public class PTFSortViewModel
    {
        public PTFSortState TitleSort { get; }
        public PTFSortState CodeWordSort { get; }
        public PTFSortState Current { get; }

        public PTFSortViewModel(PTFSortState sortOrder)
        {
            TitleSort = sortOrder == PTFSortState.TitleAsc ? PTFSortState.TitleDesc : PTFSortState.TitleAsc;
            CodeWordSort = sortOrder == PTFSortState.CodeWordAsc ? PTFSortState.TitleDesc : PTFSortState.TitleAsc;
            Current = sortOrder;
        }
    }
}
