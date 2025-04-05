using FluentValidation;
using Library.DTO.Requests.Book;

namespace Library.Data.Validators.Book;

public class AddRequestValidator : AbstractValidator<AddBookRequest>
{
    public AddRequestValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title is required.")
            .MaximumLength(100)
            .WithMessage("Title must not exceed 100 characters.");

        RuleFor(x => x.AuthorName)
            .NotEmpty()
            .WithMessage("Author name is required.");

        RuleFor(x => x.GenreName)
            .NotEmpty()
            .WithMessage("Genre name is required.");

        RuleFor(x => x.Publisher)
            .NotEmpty()
            .WithMessage("Publisher name is required.")
            .MaximumLength(100)
            .WithMessage("Publisher must not exceed 100 characters.");
    }
}