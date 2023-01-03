using System.ComponentModel.DataAnnotations;

namespace TheBookstown.Domain.Entities
{
    public class Book : BaseEntity
    {
        [Required]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Name of the book")]
        public override string? Name { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }

        public Guid AuthorId { get; set; }
        public Author? Author { get; set; }

        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
