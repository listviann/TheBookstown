using System.ComponentModel.DataAnnotations.Schema;

namespace TheBookstown.Domain.Entities
{
    // order based on cart items
    public class OrderItem : BaseEntity
    {
        public List<OrderDetail> OrderDetails { get; set; } = new();
        
        public int TotalCost { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
    }
}
