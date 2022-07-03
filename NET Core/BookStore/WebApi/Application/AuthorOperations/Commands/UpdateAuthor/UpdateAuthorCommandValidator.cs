using FluentValidation;
namespace WebApi.Application.AuthorOperations.UpdateAuthorCommand
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
        {
            RuleFor(command => command.AuthorId).GreaterThan(0);
            RuleFor(command => command.Model.BirthDate).LessThan(DateTime.Now);
        }
    }
}