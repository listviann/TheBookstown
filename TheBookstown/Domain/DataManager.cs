using TheBookstown.Domain.Repositories.Abstract;

namespace TheBookstown.Domain
{
    public class DataManager
    {
        public IAuthorRepository Authors { get; set; }
        public IBookRepository Books { get; set; }
        public IGenreRepository Genres { get; set; }
        public IUserRepository Users { get; set; }
        public IUserCartRepository UserCartItems { get; set; }
        public IOrderItemRepository OrderItems { get; set; }
        public IPageTextFieldRepository PagesTextFields { get; set; }

        public DataManager(IAuthorRepository authors, IBookRepository books, IGenreRepository genres, IPageTextFieldRepository pagesTextFields,
            IUserRepository users, IUserCartRepository userCartItems, IOrderItemRepository orderItems)
        {
            Authors = authors;
            Books = books;
            Genres = genres;
            Users = users;
            UserCartItems = userCartItems;
            OrderItems = orderItems;
            PagesTextFields = pagesTextFields;
        }
    }
}
