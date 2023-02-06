using Library.DAL.Contexts;
using Library.DAL.Interfaces;
using Library.DAL.Models.Entities;
using Library.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;
        private GenericRepository<Book> _bookRepository;
        private GenericRepository<Genre> _genreRepository;
        private GenericRepository<Author> _authorRepository;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }
        public GenericRepository<Book> BookRepository
        {
            get
            {
                if (this._bookRepository == null)
                {
                    this._bookRepository = new GenericRepository<Book>(_context);
                }
                return _bookRepository;
            }
        }
        public GenericRepository<Genre> GenreRepository
        {
            get
            {
                if (this._genreRepository == null)
                {
                    this._genreRepository = new GenericRepository<Genre>(_context);
                }
                return _genreRepository;
            }
        }
        public GenericRepository<Author> AuthorRepository 
        {
            get
            {
                if (this._authorRepository == null)
                {
                    this._authorRepository = new GenericRepository<Author>(_context);
                }
                return _authorRepository;
            }
        }
        public GenericRepository<BookGenre> BookGenreRepository { get; private set; }
        public GenericRepository<BookAuthor> BookAuthorRepository { get; private set; }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.DisposeAsync();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
