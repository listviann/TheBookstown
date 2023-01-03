using TheBookstown.Domain.Entities;
using TheBookstown.Domain.Repositories.Abstract;

namespace TheBookstown.Domain.Repositories.EntityFramework
{
    public class EFPageTextFieldRepository : IPageTextFieldRepository
    {
        private readonly AppDbContext _db;

        public EFPageTextFieldRepository(AppDbContext db)
        {
            _db = db;
        }

        public void DeletePageTextField(Guid id)
        {
            _db.PagesTextFields.Remove(new PageTextField { Id = id });
            _db.SaveChanges();
        }

        public PageTextField GetPageTextFieldByCodeWord(string codeWord)
        {
            return _db.PagesTextFields.FirstOrDefault(p => p.CodeWord == codeWord)!;
        }

        public PageTextField GetPageTextFieldById(Guid id)
        {
            return _db.PagesTextFields.FirstOrDefault(p => p.Id == id)!;
        }

        public IQueryable<PageTextField> GetPageTextFields()
        {
            return _db.PagesTextFields;
        }

        public void SavePageTextField(PageTextField entity)
        {
            if (entity.Id == default)
            {
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            _db.SaveChanges();
        }
    }
}
