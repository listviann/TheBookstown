using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using TheBookstown.Models;

namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFBookRepository : IBookRepository
    {
        private readonly AppDbContext _db;

        public EFBookRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Delete(Guid id)
        {
            _db.Books.Remove(new Book() { Id = id });
        }

        public Book GetBookById(Guid id)
        {
            return _db.Books.Include(a => a.Author).Include(a => a.Genre).FirstOrDefault(b => b.Id == id)!;
        }

        public IQueryable<Book> GetBooks()
        {
            return _db.Books;
        }

        public List<BookViewModel> GetBooksModels()
        {
            return _db.Books.Select(b => new BookViewModel()
            {
                BookId = b.Id,
                BookName = b.Name,
                BookAuthorName = b.Author!.Name,
                BookGenreName = b.Genre!.Name,
                BookPrice = b.Price
            }).ToList();
        }

        public void Save(Book entity)
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
