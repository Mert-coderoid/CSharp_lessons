using FluentValidation;

namespace WebApi.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQueryValidation : AbstractValidator<GetGenreDetailQuery>
    {
        public GetGenreDetailQueryValidation()
        {
            RuleFor(command => command.GenreId).GreaterThan(0);
        }
    }
}