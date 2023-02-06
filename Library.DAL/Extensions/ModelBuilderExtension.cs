using Library.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            var authors = new List<Author> ()
            {
                new Author{ AuthorId = Guid.NewGuid(), Name = "Alexander Pushkin" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Mikhail Lermontov" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Nikolai Nekrasov" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Fyodor Tyutchev" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Alexander Blok" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Anna Akhmatova" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Marina Tsvetaeva" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Sergei Yesenin" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Vladimir Mayakovsky" },
                new Author{ AuthorId = Guid.NewGuid(), Name = "Lev Tolstoy" }
            };
            var genres = new List<Genre>()
            {
                new Genre{ GenreId = Guid.NewGuid(), Name = "Fantasy" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Dystopian" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Adventure" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Romance" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Detective" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Horror" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "History" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Biography" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Comedy" },
                new Genre{ GenreId = Guid.NewGuid(), Name = "Education" }
            };
            var books = new List<Book>()
            {
                new Book{ BookId = Guid.NewGuid(), Name = "Book 1", Year = "5364",
                    Authors = authors.Skip(8).ToList(),
                    Genres = genres.Skip(6).ToList()
                },
                new Book{ BookId = Guid.NewGuid(), Name = "Book 2", Year = "1789",
                    Authors = authors.SkipLast(7).ToList(),
                    Genres = genres.SkipLast(7).ToList()
                },
                new Book{ BookId = Guid.NewGuid(), Name = "Book 3", Year = "876",
                    Authors = authors.SkipLast(9).ToList(),
                    Genres = genres.Skip(8).ToList()
                }
            };

            builder.Entity<Author>().HasData(authors);
            builder.Entity<Genre>().HasData(genres);
            //builder.Entity<Book>().HasData(books);
        }
    }
}
