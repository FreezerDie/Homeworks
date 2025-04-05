using FluentValidation;
using Library.DTO.Requests.Author;

namespace Library.Data.Validators.Author;

public class UpdateRequestValidator : AbstractValidator<AuthorUpdateRequest>
{
    public UpdateRequestValidator()
    {
        RuleFor(x => x.FindByName)
            .NotEmpty()
            .WithMessage("Name is required.");
        RuleFor(x => x.NewFullName)
            .NotEmpty()
            .Length(2, 100)
            .WithMessage("Name must be between 2 and 100 characters long.");
        
    }
}