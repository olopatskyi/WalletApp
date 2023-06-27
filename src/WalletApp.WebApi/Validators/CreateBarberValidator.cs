using WalletApp.Application.Models.Requests;
using FluentValidation;

namespace WalletApp.WebApi.Validators;

public class CreateBarberValidator : AbstractValidator<CreateBarberVm>
{
    public CreateBarberValidator()
    {
        RuleFor(x => x.FirstName)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Description)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Photo)
            .NotNull()
            .NotEmpty()
            .Must(IsImageFile);

        RuleFor(x => x.RankId)
            .NotNull()
            .NotEmpty();
    }
    
    private static bool IsImageFile(IFormFile? file)
    {
        // Check if the file exists and has content
        if (file == null || file.Length == 0)
        {
            return false;
        }

        // Get the file extension
        var fileExtension = Path.GetExtension(file.FileName);

        // Define a list of allowed image file extensions
        string[] allowedExtensions = { ".jpg", ".jpeg", ".png" };

        // Check if the file extension is in the allowed extensions list
        if (!allowedExtensions.Contains(fileExtension.ToLower()))
        {
            return false;
        }

        return true;
    }
}