using System.ComponentModel.DataAnnotations.Schema;

namespace TheBookstown.Domain.Entities
{
    // cart for authenticated users
    public class UserCartItem : BaseEntity
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        [ForeignKey("BookId")]
        public Guid BookId { get; set; }
        public Book? Book { get; set; }
    }
}
