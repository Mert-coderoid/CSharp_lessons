using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider) // serviceProvider is a class that provides access to the service container.
        {
            using (var context = new BookStoreDBContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDBContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Drama"
                    },
                    new Genre
                    {
                        Name = "Action"
                    },
                    new Genre
                    {
                        Name = "Science Fiction"
                    },
                    new Genre
                    {
                        Name = "Romance"
                    },
                    new Genre
                    {
                        Name = "Horror"
                    },
                    new Genre
                    {
                        Name = "Comedy"
                    },
                    new Genre
                    {
                        Name = "Thriller"
                    },
                    new Genre
                    {
                        Name = "Fantasy"
                    },
                    new Genre
                    {
                        Name = "Mystery"
                    },
                    new Genre
                    {
                        Name = "Historical"
                    },
                    new Genre
                    {
                        Name = "Biography"
                    },
                    new Genre
                    {
                        Name = "Poetry"
                    },
                    new Genre
                    {
                        Name = "Adventure"
                    },
                    new Genre
                    {
                        Name = "Self Help"
                    },
                    new Genre
                    {
                        Name = "Guide"
                    },
                    new Genre
                    {
                        Name = "Travel"
                    },
                    new Genre
                    {
                        Name = "Children's"
                    },
                    new Genre
                    {
                        Name = "Religion, Spirituality & New Age"
                    },
                    new Genre
                    {
                        Name = "Science"
                    },
                    new Genre
                    {
                        Name = "History"
                    },
                    new Genre
                    {
                        Name = "Math"
                    },
                    new Genre
                    {
                        Name = "Anthology"
                    },
                    new Genre
                    {
                        Name = "Encyclopedias"
                    },
                    new Genre
                    {
                        Name = "Dictionaries"
                    },
                    new Genre
                    {
                        Name = "Comics"
                    },
                    new Genre
                    {
                        Name = "Art"
                    },
                    new Genre
                    {
                        Name = "Cookbooks"
                    },
                    new Genre
                    {
                        Name = "Diaries"
                    },
                    new Genre
                    {
                        Name = "Journals"
                    },
                    new Genre
                    {
                        Name = "Prayer books"
                    },
                    new Genre
                    {
                        Name = "Series"
                    },
                    new Genre
                    {
                        Name = "Trilogy"
                    },
                    new Genre
                    {
                        Name = "Biographies"
                    },
                    new Genre
                    {
                        Name = "Autobiographies"
                    }
                );

                context.Books.AddRange(
                    new Book
                    {
                        // Id = 1,
                        Title = "The Hobbit",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 295,
                        PublishDate = new DateTime(1937, 9, 21)
                    },
                    new Book
                    {
                        // Id = 2,
                        Title = "The Fellowship of the Ring",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 423,
                        PublishDate = new DateTime(1954, 7, 29)
                    },
                    new Book
                    {
                        // Id = 3,
                        Title = "The Two Towers",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 352,
                        PublishDate = new DateTime(1954, 11, 11)
                    },
                    new Book
                    {
                        // Id = 4,
                        Title = "The Return of the King",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 416,
                        PublishDate = new DateTime(1955, 10, 20)
                    },
                    new Book
                    {
                        // Id = 5,
                        Title = "The Silmarillion",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 429,
                        PublishDate = new DateTime(1977, 9, 15)
                    },
                    new Book
                    {
                        // Id = 6,
                        Title = "The Children of Hurin",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 304,
                        PublishDate = new DateTime(2007, 11, 6)
                    },
                    new Book
                    {
                        // Id = 7,
                        Title = "The Lord of the Rings",
                        GenreId = 1,
                        WriterId = 1,
                        PageCount = 1216,
                        PublishDate = new DateTime(1954, 7, 29)
                    },
                    new Book
                    {
                        // Id = 8,
                        Title = "Crime and Punishment",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 551,
                        PublishDate = new DateTime(1866, 1, 1)
                    },
                    new Book
                    {
                        // Id = 9,
                        Title = "The Brothers Karamazov",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 824,
                        PublishDate = new DateTime(1880, 1, 1)
                    },
                    new Book
                    {
                        // Id = 10,
                        Title = "The Idiot",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 656,
                        PublishDate = new DateTime(1869, 1, 1)
                    },
                    new Book
                    {
                        // Id = 11,
                        Title = "The Possessed",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 768,
                        PublishDate = new DateTime(1872, 1, 1)
                    },
                    new Book
                    {
                        // Id = 12,
                        Title = "Demons",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 672,
                        PublishDate = new DateTime(1872, 1, 1)
                    },
                    new Book
                    {
                        // Id = 13,
                        Title = "The Adolescent",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 432,
                        PublishDate = new DateTime(1875, 1, 1)
                    },
                    new Book
                    {
                        // Id = 14,
                        Title = "The Gambler",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 432,
                        PublishDate = new DateTime(1867, 1, 1)
                    },
                    new Book
                    {
                        // Id = 15,
                        Title = "The House of the Dead",
                        GenreId = 2,
                        WriterId = 2,
                        PageCount = 432,
                        PublishDate = new DateTime(1862, 1, 1)
                    },
                    new Book
                    {
                        // Id = 16,
                        Title = "The Master and Margarita",
                        GenreId = 3,
                        WriterId = 3,
                        PageCount = 470,
                        PublishDate = new DateTime(1966, 1, 1)
                    },
                    new Book
                    {
                        // Id = 17,
                        Title = "And Quiet Flows the Don",
                        GenreId = 3,
                        WriterId = 3,
                        PageCount = 448,
                        PublishDate = new DateTime(1940, 1, 1)
                    },
                    new Book
                    {
                        // Id = 18,
                        Title = "The Death of Ivan Ilyich",
                        GenreId = 3,
                        WriterId = 3,
                        PageCount = 96,
                        PublishDate = new DateTime(1886, 1, 1)
                    },
                    new Book
                    {
                        // Id = 19,
                        Title = "Dune",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 604,
                        PublishDate = new DateTime(1965, 1, 1)
                    },
                    new Book
                    {
                        // Id = 20,
                        Title = "Herland",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 144,
                        PublishDate = new DateTime(1915, 1, 1)
                    },
                    new Book
                    {
                        // Id = 21,
                        Title = "The Dispossessed",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 288,
                        PublishDate = new DateTime(1974, 1, 1)
                    },
                    new Book
                    {
                        // Id = 22,
                        Title = "The Left Hand of Darkness",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 288,
                        PublishDate = new DateTime(1969, 1, 1)
                    },
                    new Book
                    {
                        // Id = 23,
                        Title = "The Lathe of Heaven",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 288,
                        PublishDate = new DateTime(1971, 1, 1)
                    },
                    new Book
                    {
                        // Id = 24,
                        Title = "The Tombs of Atuan",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 288,
                        PublishDate = new DateTime(1971, 1, 1)
                    },
                    new Book
                    {
                        // Id = 25,
                        Title = "The Word for World is Forest",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 288,
                        PublishDate = new DateTime(1972, 1, 1)
                    },
                    new Book
                    {
                        // Id = 26,
                        Title = "The Penultimate Truth",
                        GenreId = 4,
                        WriterId = 4,
                        PageCount = 288,
                        PublishDate = new DateTime(1982, 1, 1)
                    }
                );

                context.SaveChanges();
            }
        }
    }
}