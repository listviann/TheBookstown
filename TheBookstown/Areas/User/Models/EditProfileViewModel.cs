using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBookstown.Areas.User.Models
{
    [NotMapped]
    public class EditProfileViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string? UserName { get; set; }
    }
}
