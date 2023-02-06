using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models.Entities
{
    [PrimaryKey(nameof(BookId), nameof(GenreId))]
    public class BookGenre
    {
        public Guid BookId { get; set; }
        public Guid GenreId { get; set; }

        public List<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
