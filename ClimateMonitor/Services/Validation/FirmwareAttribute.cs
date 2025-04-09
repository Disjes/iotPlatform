using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ClimateMonitor.Services.Validation;

public class FirmwareAttribute : ValidationAttribute
{
    private static readonly Regex SemVerRegex = new Regex(
        "^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$",
        RegexOptions.IgnoreCase | RegexOptions.Compiled
    );

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string str && SemVerRegex.IsMatch(str))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("The firmware value does not match semantic versioning format.");
    }
}