using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.AuthorLevelGroup
{
    public class BronzeAuthorLevelGroup : IAuthorLevelGroup
    {
        public IEnumerable<AuthorLevelGroup> Group(IEnumerable<BookCatalogue> bookCatalogues)
        {
            var bookRecordset = bookCatalogues as BookCatalogue[] ?? bookCatalogues.ToArray();

            if (!bookRecordset.Any()) return new List<AuthorLevelGroup>();

            return bookRecordset.Select(t =>
                new AuthorLevelGroup
                {
                    AuthorName = t.Books.FirstOrDefault().Author,
                    Books=t.Books,
                    LevelGroupName=LevelGroup.Bronze
                }) ;
        }
    }
}
