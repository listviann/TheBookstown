using TheBookstown.Domain.Entities;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAuthors();
        Author GetAuthorById(Guid id);
        void Save(Author entity);
        void Delete(Guid id);
    }
}
