using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace wedding_planner.Models
{
  [NotMapped]
  public class UserLogin
  {
    [Required(ErrorMessage = "Email Address is required")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LoginEmail { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string LoginPassword { get; set; }
  }

}