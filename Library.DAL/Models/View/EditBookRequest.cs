using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models.View
{
    public class EditBookRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public List<Guid> Authors { get; set; }
        public List<Guid> Genres { get; set; }
    }
}
