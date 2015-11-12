using System.Globalization;
using System.Windows.Controls;

namespace FlatTheme.Code
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "Thông tin bắt buộc!")
                : ValidationResult.ValidResult;
        }
    }
}