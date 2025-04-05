using FluentValidation;
using Library.DTO.Requests.Book;

namespace Library.Data.Validators.Book;

public class FindDeleteRequestValidator : AbstractValidator<FindDeleteBookRequest>
{
    public FindDeleteRequestValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title is required.");
    }
}