using FluentValidation;
namespace WebApi.Application.BookOperations.Commands.DeleteBookCommand
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}