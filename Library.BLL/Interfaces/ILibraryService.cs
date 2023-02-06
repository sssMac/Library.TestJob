using Library.DAL.Models.Entities;
using Library.DAL.Models.View;


namespace Library.BLL.Interfaces
{
    public interface ILibraryService
    {
        Task<List<Author>> GetAllAuthors();
        Task<List<Genre>> GetAllGenres();
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBook(Guid id);
        Task AddBook(AddBookRequest book);
        Task DeleteBook(Guid id);
        Task EditBook(EditBookRequest model);
    }
}
