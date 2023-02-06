using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models.Entities
{
    [PrimaryKey(nameof(BookId), nameof(AuthorId))]
    public class BookAuthor
    {
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }

        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
    }
}
