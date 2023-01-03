using TheBookstown.Domain.Entities;
using TheBookstown.Models;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();
        Book GetBookById(Guid id);
        void Save(Book entity);
        void Delete(Guid id);
        List<BookViewModel> GetBooksModels();
    }
}
