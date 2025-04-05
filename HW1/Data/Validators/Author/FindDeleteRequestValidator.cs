using FluentValidation;
using Library.DTO.Requests.Author;

namespace Library.Data.Validators.Author;

public class FindDeleteRequestValidator : AbstractValidator<AuthorFindDeleteRequest>
{
    public FindDeleteRequestValidator()
    {
        RuleFor(x => x.FindByName)
            .NotEmpty()
            .WithMessage("Name is required.");
    }
}