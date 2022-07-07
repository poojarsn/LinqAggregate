using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.Domain
{
    public class BookCatalogue
    {
        public IList<Book> Books { get; set; }
        public string Category { get; set; }
    }
}
