using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.AuthorLevelGroup
{
    public interface IAuthorLevelGroup
    {
        IEnumerable<AuthorLevelGroup> Group(IEnumerable<BookCatalogue> bookCatalogues);
    }
}

