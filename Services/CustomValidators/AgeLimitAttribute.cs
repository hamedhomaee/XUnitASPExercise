using System.ComponentModel.DataAnnotations;

namespace XUnit.Services.CustomValidators;

public class AgeLimitAttribute : ValidationAttribute
{
    public string? DefaultErrorMessage { get; set; } = "The value cannot be older than 1st Jan. 2000";
    
    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    {
        if(Convert.ToDateTime(value).CompareTo(new DateTime(2000, 1, 1)) >= 0)
            return ValidationResult.Success;
        else
            return new ValidationResult(ErrorMessage);
    }
}