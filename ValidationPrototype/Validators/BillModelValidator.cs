using FluentValidation;
using ValidationPrototype.Models;

namespace ValidationPrototype.Validators
{
    public class BillModelValidator : AbstractValidator<BillModel>
    {
        public BillModelValidator()
        {
            RuleFor(x => x.BillName).NotEmpty().WithMessage("Please enter a name for this bill")
                .WithState(bill => bill);
            RuleFor(x => x.BilleeContact).SetValidator(new ContactModelValidator())
                .WithState(billee => billee)
                .WithMessage("Please verify required fields for the Billee are populated")
                .WithName("Model.BileeContact");
            RuleFor(x => x.BillerContact).SetValidator(new ContactModelValidator())
                .WithState(biller => biller)
                .WithMessage("Please verify required fields for the Billee are populated")
                .WithMessage("Model.BillerContact");
        }
    }
}
