using Linq_Aggregation.AuthorLevelGroup;
using Linq_Aggregation.AuthorLevelGroupFilter;
using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.AuthorLevelAggregate
{
    public class AuthorLevelGroupAggregation: IAuthorLevelGroup
    {
        private readonly IDictionary<IAuthorLevelGroup, IAuthorLevelGroupFilter> _groups;

        public AuthorLevelGroupAggregation()
        {
            _groups = new Dictionary<IAuthorLevelGroup, IAuthorLevelGroupFilter>()
                    {
                        { new GoldAuthorLevelGroup(), new GoldAuthorLevelGroupFilter()},
                        { new SilverAuthorLevelGroup(), new SilverAuthorLevelGroupFilter()},
                        { new BronzeAuthorLevelGroup(), new BronzeAuthorLevelGroupFilter()},
                    
                    };
            if (!_groups.Any())
                throw new ArgumentException(@"Must pass at least one grouping and filtering logic", nameof(_groups));
        }


        IEnumerable<AuthorLevelGroup.AuthorLevelGroup> IAuthorLevelGroup.Group(IEnumerable<BookCatalogue> bookCatalogues)
         {
            var bookRecordSet = bookCatalogues as BookCatalogue[] ?? bookCatalogues.ToArray();
            return _groups.AsParallel().Aggregate(Enumerable.Empty<AuthorLevelGroup.AuthorLevelGroup>(),
                (current, level) => current.Union(level.Key.Group(level.Value.Apply(bookRecordSet))));
        }
    }

}
