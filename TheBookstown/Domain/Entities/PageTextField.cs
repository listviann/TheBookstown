using System.ComponentModel.DataAnnotations;

namespace TheBookstown.Domain.Entities
{
    public class PageTextField : BaseEntity
    {
        [Required]
        public string? CodeWord { get; set; }

        [Required]
        [Display(Name = "Page title")]
        public override string? Name { get; set; } = "Info page";
    }
}
