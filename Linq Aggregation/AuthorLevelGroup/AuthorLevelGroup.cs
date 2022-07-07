using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aggregation.AuthorLevelGroup
{
    public class AuthorLevelGroup
    {
        public string AuthorName { get; set; }
        public IList<Book> Books { get; set; }

        public LevelGroup LevelGroupName { get; set; }
    }
    public enum LevelGroup
    {
        Gold,
        Silver,
        Bronze
    }
}
