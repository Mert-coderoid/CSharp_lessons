using System;
using FluentValidation;

namespace WebApi.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookCommandValidation : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidation()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.PageCount).GreaterThan(0);
            RuleFor(command => command.Model.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4);
        }
    }
}