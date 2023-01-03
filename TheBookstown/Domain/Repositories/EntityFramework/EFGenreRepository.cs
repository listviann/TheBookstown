using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFGenreRepository : IGenreRepository
    {
        private readonly AppDbContext _db;

        public EFGenreRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Delete(Guid id)
        {
            _db.Genres.Remove(new Genre() { Id = id });
            _db.SaveChanges();
        }

        public Genre GetGenreById(Guid id)
        {
            return _db.Genres.Include(g => g.Books).FirstOrDefault(g => g.Id == id)!;
        }

        public IQueryable<Genre> GetGenres()
        {
            return _db.Genres.Include(g => g.Books);
        }

        public void Save(Genre entity)
        {
            if (entity.Id == default)
            {
                _db.Entry(entity).State = EntityState.Added;
            }
            else
            {
                _db.Entry(entity).State = EntityState.Modified;
            }

            _db.SaveChanges();
        }
    }
}
