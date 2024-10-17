using System.ComponentModel.DataAnnotations;

namespace Financeiro.Domain.Util;
public static class ModelsValidator
{
    public static void Execute(object instance)
    {
        ValidationContext validationContext = new(instance);
        List<ValidationResult> validationResults = [];
        bool isValid = Validator.TryValidateObject(instance,
                                                   validationContext,
                                                   validationResults,
                                                   validateAllProperties: true);

        if (!isValid)
        {
            throw new ValidationException(string.Join(Environment.NewLine, validationResults.Select(x => x.ErrorMessage)));
        }
    }
}
