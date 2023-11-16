using FluentValidation;
using ValidationPrototype.Models;

namespace ValidationPrototype.Validators;

public class ContactModelValidator : AbstractValidator<ContactModel>
{
    public ContactModelValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithState(x => x);
        RuleFor(x => x.Address).NotEmpty().WithState(x => x);
        RuleFor(x => x.City).NotEmpty().WithState(x => x);
        RuleFor(x => x.State).NotEmpty().WithState(x => x);
        RuleFor(x => x.PostalCode).NotEmpty().WithState(x => x);
    }
}