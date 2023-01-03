using TheBookstown.Domain.Entities;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IGenreRepository
    {
        IQueryable<Genre> GetGenres();
        Genre GetGenreById(Guid id);
        void Save(Genre entity);
        void Delete(Guid id);
    }
}
