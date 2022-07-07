using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.AuthorLevelGroupFilter
{
    public class AuthorLevelGroupFilter : IAuthorLevelGroupFilter
    {
        public IEnumerable<BookCatalogue> Apply(IEnumerable<BookCatalogue> limits)
        {
            throw new NotImplementedException();
        }
    }
}
