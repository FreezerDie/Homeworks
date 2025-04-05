using FluentValidation;
using Library.DTO.Requests.Genre;

namespace Library.Data.Validators.Genre;

public class AddRequestValidator : AbstractValidator<AddGenreRequest>
{
    public AddRequestValidator()
    {
        RuleFor(x => x.GenreName)
            .NotEmpty()
            .WithMessage("Genre name is required.")
            .MinimumLength(3)
            .WithMessage("Genre name must be at least 3 characters long.")
            .MaximumLength(50)
            .WithMessage("Genre name must not exceed 50 characters.");
    }
}