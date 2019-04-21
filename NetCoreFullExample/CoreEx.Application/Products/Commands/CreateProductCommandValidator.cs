using FluentValidation;

namespace CoreEx.Application.Products.Commands
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Category).MaximumLength(60).NotEmpty();
        }
    }
}
