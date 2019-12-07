using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace wedding_planner.Models
{
  [NotMapped]
  public class UserRegistration
  {
    [Required(ErrorMessage = "First Name is required")]
    [MinLength(2, ErrorMessage = "First Name must be at least 8 characters long.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    [MinLength(2, ErrorMessage = "Last Name must be at least 8 characters long.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email Address is required")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [Compare("ConfirmPassword")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
    public string Password { get; set; }

    [NotMapped]
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }
  }
}