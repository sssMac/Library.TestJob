using Library.BLL.Interfaces;
using Library.DAL.Interfaces;
using Library.DAL.Models.Entities;
using Library.DAL.Models.View;


namespace Library.BLL.Services
{
    public class LibraryService : ILibraryService
    {
        private IUnitOfWork _unitOfWork;

        public LibraryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Author>> GetAllAuthors() => 
            (await _unitOfWork.AuthorRepository.Get()).ToList();
        public async Task<List<Genre>> GetAllGenres() => 
            (await _unitOfWork.GenreRepository.Get()).ToList();
        public async Task<List<Book>> GetAllBooks() =>
            (await _unitOfWork.BookRepository.Get(null, null, "Authors,Genres")).ToList();

        public async Task<Book> GetBook(Guid id)
        {
            return await _unitOfWork.BookRepository.GetByID(id, "Authors,Genres");
        }
        public async Task AddBook(AddBookRequest model)
        {
            var authors = await _unitOfWork.AuthorRepository.Get(
                a1 => model.Authors.Any(
                    a2 => a1.AuthorId == a2));

            var genres = await _unitOfWork.GenreRepository.Get(
                g1 => model.Genres.Any(
                    g2 => g1.GenreId == g2));

            var book = new Book
            {
                BookId = Guid.NewGuid(),
                Name = model.Name,
                Year = model.Year,
                Authors = authors.ToList(),
                Genres = genres.ToList()
            };

            await _unitOfWork.BookRepository.Insert(book);
            await _unitOfWork.Save();
        }
        public async Task DeleteBook(Guid id)
        {
            await _unitOfWork.BookRepository.Delete(id);
            await _unitOfWork.Save();
        }
        public async Task EditBook(EditBookRequest model)
        {
            var editedBook = (await _unitOfWork.BookRepository
                .Get(b => b.BookId == model.Id, null, "Authors,Genres"))
                .First();

            var authors = await _unitOfWork.AuthorRepository.Get(
                a1 => model.Authors.Any(
                    a2 => a1.AuthorId == a2));

            var genres = await _unitOfWork.GenreRepository.Get(
                g1 => model.Genres.Any(
                    g2 => g1.GenreId == g2));

            editedBook.Name = model.Name;
            editedBook.Year = model.Year;
            editedBook.Authors = authors.ToList();
            editedBook.Genres = genres.ToList();
            editedBook.EditDate = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            await _unitOfWork.BookRepository.Update(editedBook);
            await _unitOfWork.Save();
        }

    }
}
