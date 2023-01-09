using TheBookstown.Domain.Entities;
using TheBookstown.Models;

namespace TheBookstown.Areas.Admin.Models
{
    public class GenresIndexViewModel
    {
        public IEnumerable<Genre> Genres { get; }
        public PageViewModel PageViewModel { get; }
        public GenresSortViewModel SortViewModel { get; }
        public GenresFilterViewModel FilterViewModel { get; }

        public GenresIndexViewModel(IEnumerable<Genre> genres, PageViewModel pageViewModel,
            GenresSortViewModel sortViewModel, GenresFilterViewModel filterViewModel)
        {
            Genres = genres;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}
