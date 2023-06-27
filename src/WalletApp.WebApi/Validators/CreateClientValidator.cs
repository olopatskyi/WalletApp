using WalletApp.Application.Models.Requests;
using FluentValidation;

namespace WalletApp.WebApi.Validators;

public class CreateClientValidator : AbstractValidator<CreateClientVm>
{
    public CreateClientValidator()
    {
        RuleFor(x => x.Email)
            .NotNull()
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.PhoneNumber)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty();
    }
}