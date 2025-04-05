using FluentValidation;
using Library.DTO.Requests.Genre;

namespace Library.Data.Validators.Genre;

public class FindDeleteRequestValidator : AbstractValidator<FindDeleteGenreRequest>
{
    public FindDeleteRequestValidator()
    {
        RuleFor(x => x.FindByName)
            .NotEmpty()
            .WithMessage("GenreName is required.");
    }
}