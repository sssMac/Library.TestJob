using Library.DAL.Models.Entities;
using Library.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public GenericRepository<Book> BookRepository { get; }
        public GenericRepository<Genre> GenreRepository { get; }
        public GenericRepository<Author> AuthorRepository { get; }
        public GenericRepository<BookGenre> BookGenreRepository { get; }
        public GenericRepository<BookAuthor> BookAuthorRepository { get; }

        public Task Save();
        public void Dispose();
    }
}
