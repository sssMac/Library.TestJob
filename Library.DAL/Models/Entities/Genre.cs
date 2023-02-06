using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models.Entities
{
    public class Genre
    {
        public Genre()
        {
            this.Books = new HashSet<Book>();
        }
        public Guid GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}
