namespace TheBookstown.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public string? BookTitle { get; set; }
        public int Price { get; set; }
        public virtual Book? Book { get; set; }
        public virtual OrderItem? Order { get; set; }
    }
}