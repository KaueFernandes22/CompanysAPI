using CompanysAPI.Model;
using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace CompanysAPI.Validators
{
    public class CreateCompanyValidator : AbstractValidator<Company>
    {
        public CreateCompanyValidator()
        {
            RuleFor(x => x.CompanyName).NotNull().NotEmpty().WithMessage("Name is required").MinimumLength(5).WithMessage("Minimum length must be 5 characters").
                MaximumLength(50).WithMessage("Maximum length mus be 50 characters");

            RuleFor(x => x.DocumentNumber).NotNull().NotEmpty().WithMessage("Document Number is required");

            RuleFor(x => x.Address).NotNull().NotEmpty().WithMessage("Address is required");
        }
    }
}
