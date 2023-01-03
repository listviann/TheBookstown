using TheBookstown.Domain.Entities;

namespace TheBookstown.Domain.Repositories.Abstract
{
    public interface IPageTextFieldRepository
    {
        IQueryable<PageTextField> GetPageTextFields();
        PageTextField GetPageTextFieldById(Guid id);
        PageTextField GetPageTextFieldByCodeWord(string codeWord);
        void SavePageTextField(PageTextField entity);
        void DeletePageTextField(Guid id);
    }
}
