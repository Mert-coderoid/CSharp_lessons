using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommand
    {
        public int GenreId { get; set; }
        private readonly BookStoreDBContext _dbContext;
        public UpdateGenreModel Model { get; set; }
    
        public UpdateGenreCommand(BookStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(x => x.Id == GenreId);
            if(genre is null)
                throw new InvalidOperationException("Kitap türü bulunamadı.");
            
            if(_dbContext.Genres.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Id != GenreId))
                throw new InvalidOperationException("Bu isimde bir kitap türü zaten mevcut.");

            genre.Name = Model.Name != default ? Model.Name : genre.Name;
            genre.IsActive = Model.IsActive;
            _dbContext.SaveChanges();
        }

        public class UpdateGenreModel
        {
            public string Name { get; set; }
            public bool IsActive { get; set; }
        }
    }
}