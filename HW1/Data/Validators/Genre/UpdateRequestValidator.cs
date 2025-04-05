using FluentValidation;
using Library.DTO.Requests.Genre;

namespace Library.Data.Validators.Genre;

public class UpdateRequestValidator : AbstractValidator<UpdateGenreRequest>
{
    public UpdateRequestValidator()
    {
        RuleFor(x => x.FindByName)
            .NotEmpty()
            .WithMessage("FindByName is required.");

        RuleFor(x => x.NewName)
            .NotEmpty()
            .WithMessage("NewName is required.");
    }
}