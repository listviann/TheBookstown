﻿using System.ComponentModel.DataAnnotations;

namespace TheBookstown.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Required]
        [UIHint("Password")]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        [UIHint("Password")]
        [Display(Name = "Confirm password")]
        public string? PasswordConfirm { get; set; }
    }
}
