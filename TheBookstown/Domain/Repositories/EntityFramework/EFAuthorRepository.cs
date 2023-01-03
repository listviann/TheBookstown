using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFAuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext _db;

        public EFAuthorRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Delete(Guid id)
        {
            _db.Authors.Remove(new Author() { Id = id });
            _db.SaveChanges();
        }

        public Author GetAuthorById(Guid id)
        {
            return _db.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == id)!;
        }

        public IQueryable<Author> GetAuthors()
        {
            return _db.Authors.Include(a => a.Books);
        }

        public void Save(Author entity)
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
