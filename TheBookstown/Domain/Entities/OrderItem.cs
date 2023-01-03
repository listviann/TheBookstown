using System.ComponentModel.DataAnnotations.Schema;

namespace TheBookstown.Domain.Entities
{
    // order based on cart items
    public class OrderItem : BaseEntity
    {
        public int TotalCost { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public List<UserCartItem> CartItems { get; set; } = new();
    }
}
