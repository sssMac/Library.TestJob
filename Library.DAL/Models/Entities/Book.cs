using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models.Entities
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
            this.Genres = new HashSet<Genre>();
        }
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }

        public long CreateDate { get; set; } = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        public long EditDate { get; set; } = DateTimeOffset.Now.ToUnixTimeMilliseconds();   


        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }

    }
}
