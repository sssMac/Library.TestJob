using Library.BLL.Interfaces;
using Library.DAL.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace Library.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private ILogger<LibraryController> _logger;
        private ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService,
            ILogger<LibraryController> logger)
        {
            _libraryService = libraryService;
            _logger = logger;
        }

        [HttpGet("authors")]
        public async Task<IActionResult> GetAllAuthors()
        {
            return Ok(await _libraryService.GetAllAuthors());
        }

        [HttpGet("genres")]
        public async Task<IActionResult> GetAllGenres()
        {
            return Ok(await _libraryService.GetAllGenres());
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = (await _libraryService
                .GetAllBooks())
                .Select(b => new
                {
                    b.BookId,
                    b.Name,
                    b.Year,
                    Authors = b
                        .Authors?
                        .Select(a => new { a.AuthorId, a.Name })
                        .ToList(),
                    Genres = b
                        .Genres?
                        .Select(g => new {g.GenreId, g.Name})
                        .ToList(),
                    b.CreateDate,
                    b.EditDate
                }).ToList();
            return Ok(books);
        }

        [HttpGet("books/{id}")]
        public async Task<IActionResult> GetBook(Guid id)
        {
            var book = await _libraryService.GetBook(id);

            return Ok(new
            {
                BookId = book.BookId,
                Name = book.Name,
                Year = book.Year,
                Authors = book.Authors.Select(a => new { a.AuthorId, a.Name }),
                Genres = book.Genres.Select(g => new { g.GenreId, g.Name }),
                CreateDate = book.CreateDate,
                EditDate = book.EditDate
            });
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromForm] AddBookRequest model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _libraryService.AddBook(model);

                return Ok($"Book {model.Name} added to library!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the AddBook action: {ex}");
                return StatusCode(500, "Internal server error");
            }
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            try
            {
                var deleteBook = await _libraryService.GetBook(id);

                if (deleteBook == null)
                {
                    return BadRequest("Book does not exist");
                }

                await _libraryService.DeleteBook(id);

                return Ok($"Book {deleteBook.Name} removed from library!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the AddBook action: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditBook([FromForm] EditBookRequest model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _libraryService.EditBook(model);

                return Ok($"Book {model.Name} has been edited!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the AddBook action: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
