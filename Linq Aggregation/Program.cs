using Linq_Aggregation.AuthorLevelAggregate;
using Linq_Aggregation.AuthorLevelGroup;
using Linq_Aggregation.Domain;
using System;
using System.Collections.Generic;

namespace Linq_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookCatalogues1 = new BookCatalogue();
            bookCatalogues1.Category = "Fiction";
            bookCatalogues1.Books = new List<Book>();
            bookCatalogues1.Books.Add(new Book { Author = "San", ID = 1, Language = "Eng", Name = "Sun Set-San0" });
            bookCatalogues1.Books.Add(new Book { Author = "Ron", ID = 2, Language = "Eng", Name = "Sun Set-Ron" });
            bookCatalogues1.Books.Add(new Book { Author = "Amo", ID = 3, Language = "Eng", Name = "Sun Set-Amo" });
            bookCatalogues1.Books.Add(new Book { Author = "Kon", ID = 4, Language = "Eng", Name = "Sun Set-Kon" });
            bookCatalogues1.Books.Add(new Book { Author = "San", ID = 5, Language = "Eng", Name = "Sun Set-San1" });

            var bookCatalogues2 = new BookCatalogue();
            bookCatalogues2.Books = new List<Book>();
            bookCatalogues2.Category = "Non Fiction";
            bookCatalogues2.Books.Add(new Book { Author = "RT", ID = 1, Language = "Eng", Name = "Rise-Rt" });
            bookCatalogues2.Books.Add(new Book { Author = "KT", ID = 2, Language = "Eng", Name = "KT Set-Kt" });
            bookCatalogues2.Books.Add(new Book { Author = "Amo", ID = 3, Language = "Eng", Name = "Amo Set-Amo" });
           
            var bookCatalogues3 = new BookCatalogue();
            bookCatalogues3.Category = "No Category";
            bookCatalogues3.Books = new List<Book>();
            bookCatalogues3.Books.Add(new Book { Author = "RT", ID = 1, Language = "Eng", Name = "Sun Set-Rt0" });
            bookCatalogues3.Books.Add(new Book { Author = "Sr", ID = 2, Language = "Eng", Name = "Sun Set-Sn" });
            bookCatalogues3.Books.Add(new Book { Author = "KT", ID = 3, Language = "Eng", Name = "Sun Set-Kr" });
            bookCatalogues3.Books.Add(new Book { Author = "Kon", ID = 4, Language = "Eng", Name = "Sun Set-Kon" });
            bookCatalogues3.Books.Add(new Book { Author = "Lion", ID = 5, Language = "Eng", Name = "Sun Set-Lion" });

            var bookCatalogues = new List<BookCatalogue>();
            bookCatalogues.Add(bookCatalogues1);
            bookCatalogues.Add(bookCatalogues2);
            bookCatalogues.Add(bookCatalogues3);
          
            //var response=bookCatalogues.SelectMany(p => p.Books).GroupBy(q => q.Author).Where(r=>r.Count()==2);
            IAuthorLevelGroup grouping = new AuthorLevelGroupAggregation();
            var grouped= grouping.Group(bookCatalogues);
            foreach (var author in grouped)
            {
                Console.WriteLine($"Author Name: {author.AuthorName}");
                Console.WriteLine($"Author Level: {author.LevelGroupName}");
                foreach (var book in author.Books)
                {
                    Console.WriteLine($"Book Id: {book.ID}");
                    Console.WriteLine($"Book Name: {book.Name}");
                }
            }
        }
    }
}
