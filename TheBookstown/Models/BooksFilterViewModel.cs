using Microsoft.AspNetCore.Mvc.Rendering;
using TheBookstown.Domain.Entities;

namespace TheBookstown.Models
{
    public class BooksFilterViewModel
    {
        public string SelectedBookName { get; }
        public Guid SelectedGenre { get; }
        public SelectList Genres { get; }
        public string SelectedAuthorName { get; }

        public BooksFilterViewModel(List<Genre> genres, Guid genre, string bookName, string authorName)
        {
            genres.Insert(default, new Genre() { Name = "All" });
            Genres = new SelectList(genres, "Id", "Name", genre);
            SelectedAuthorName = authorName;
            SelectedBookName = bookName;
        }
    }
}
