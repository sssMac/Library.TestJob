using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models.Entities
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        public Guid AuthorId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
