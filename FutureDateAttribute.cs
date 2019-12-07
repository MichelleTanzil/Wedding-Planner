using System;
using System.ComponentModel.DataAnnotations;
namespace wedding_planner
{
    public class FutureDateAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      // You first may want to unbox "value" here and cast to to a DateTime variable!
      DateTime CurrentTime = DateTime.Now;
      if ((DateTime)value < CurrentTime)
      {
        return new ValidationResult("Wedding date must be in the future. ");
      }
      return ValidationResult.Success;
    }
  }
}