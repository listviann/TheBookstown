using System.ComponentModel.DataAnnotations;

namespace TheBookstown.Domain.Entities
{
    public class Genre : BaseEntity
    {
        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Name of the genre")]
        public override string? Name { get; set; }

        public List<Book> Books { get; set; } = new();
    }
}
