using WalletApp.Application.Models.Requests.Booking;
using FluentValidation;

namespace WalletApp.WebApi.Validators;

public class CreateBookingValidator : AbstractValidator<CreateBookingVm>
{
    public CreateBookingValidator()
    {
        RuleFor(x => x.Client)
            .NotNull()
            .SetValidator(new CreateClientValidator());

        RuleFor(x => x.Time)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.BarberId)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.ServiceId)
            .NotNull()
            .NotEmpty();
    }   
}