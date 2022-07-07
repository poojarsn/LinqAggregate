using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.AuthorLevelGroupFilter
{
    public class SilverAuthorLevelGroupFilter: IAuthorLevelGroupFilter
    {
        public IEnumerable<BookCatalogue> Apply(IEnumerable<BookCatalogue> bookCatalogues)
        {
            return bookCatalogues.Where(p => p.Books.GroupBy(q => q.Author).Count() == 2);
        }
    }
}
