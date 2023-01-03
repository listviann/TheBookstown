using System.ComponentModel.DataAnnotations;

namespace TheBookstown.Domain.Entities
{
    public class Author : BaseEntity
    {
        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Author's name")]
        public override string? Name { get; set; }

        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
