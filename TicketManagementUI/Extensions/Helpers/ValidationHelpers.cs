using Domain.DTO.Request;
using System.ComponentModel.DataAnnotations;

namespace TicketManagementUI.Extensions.Helpers
{
    public class ValidationHelpers
    {
        public List<ValidationResult> validationResults = new List<ValidationResult>();
        ValidationContext _validationContext;
        object _instance;

        public ValidationHelpers(object instance)
        {
            _instance = instance;
            _validationContext = new ValidationContext(instance);
        }

        public bool Validate()
        {
            return Validator.TryValidateObject(_instance, _validationContext, validationResults, true);
        }
    }
}
