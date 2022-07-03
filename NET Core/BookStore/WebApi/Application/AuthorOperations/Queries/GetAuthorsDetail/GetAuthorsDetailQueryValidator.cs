using FluentValidation;
namespace WebApi.Application.AuthorOperations.GetAuthorDetailQuery
{
    public class GetAuthorsDetailQueryValidator : AbstractValidator<GetAuthorDetailQuery>
    {
        public GetAuthorsDetailQueryValidator()
        {
            RuleFor(query => query.AuthorId).NotEmpty().GreaterThan(0);
        }
    }
}