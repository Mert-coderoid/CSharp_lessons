using FluentValidation;

namespace WebApi.Application.BookOperations.Querries.GetBookDetail
{
    public class GetBookDetailQueryValidation : AbstractValidator<GetBookDetailQuery>
    {
        public GetBookDetailQueryValidation()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
        }
    }
}