using FluentValidation;
namespace WebApi.Application.AuthorOperations.CreateAuthorCommand
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(command => command.Model.Name.Trim()).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.Surname.Trim()).NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.BornDate).NotEmpty();
        }
    }
}