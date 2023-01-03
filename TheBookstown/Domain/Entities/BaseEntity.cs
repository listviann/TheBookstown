using System.ComponentModel.DataAnnotations;

namespace TheBookstown.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public virtual string? Name { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        protected BaseEntity() => DateAdded = DateTime.Now;
    }
}
