using FluentValidation;
namespace WebApi.Application.BookOperations.Commands.UpdateBookCommand
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(1);
            RuleFor(command => command.Model.GenreId).GreaterThan(0).NotEmpty();
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}