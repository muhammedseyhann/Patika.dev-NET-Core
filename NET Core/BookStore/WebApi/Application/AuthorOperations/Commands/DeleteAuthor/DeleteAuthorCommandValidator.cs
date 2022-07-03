using FluentValidation;
namespace WebApi.Application.AuthorOperations.DeleteAuthorCommand
{
    public class DeleteAuthorCommandValidator : AbstractValidator<DeleteAuthorCommand>
    {
        public DeleteAuthorCommandValidator()
        {
            RuleFor(command => command.AuthorId).NotEmpty().GreaterThan(0);
        }
    }
}