using FluentValidation;
using Library.DTO.Requests.Book;

namespace Library.Data.Validators.Book;

public class UpdateRequestValidator : AbstractValidator<UpdateBookRequest>
{
    public UpdateRequestValidator() 
    {
        RuleFor(x => x.FindByTitle)
            .NotEmpty()
            .WithMessage("FindByTitle is required.");

        RuleFor(x => x.NewTitle)
            .NotEmpty()
            .WithMessage("NewTitle is required.");

        RuleFor(x => x.Publisher)
            .NotEmpty()
            .WithMessage("Publisher is required.");
    }
}