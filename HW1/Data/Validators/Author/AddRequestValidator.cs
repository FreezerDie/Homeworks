using FluentValidation;
using Library.DTO.Requests.Author;

namespace Library.Data.Validators.Author;

public class AddRequestValidator : AbstractValidator<AuthorAddRequest>
{
    public AddRequestValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty()
            .WithMessage("Name is required.")
            .Length(2, 100)
            .WithMessage("Name must be between 2 and 100 characters long.");

      
    }
}