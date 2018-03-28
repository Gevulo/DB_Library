using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    static class SearchBook
    {
        public static object Search(string s )
        {
            LibraryEntities le = new LibraryEntities();

                var auth = le.Author.ToList();
                var books = le.Books.ToList();                
                                              
                var booksInfo = books.Join(auth, x => x.id_Author, y => y.id, (x, y) => new BookInfo
                    {
                        AuthorFirstName = y.Name,
                        AuthorSecondName = y.Surname,
                        Genre = x.Gener,
                        PublishingYear = x.Year,
                        Title = x.NameBook
                    });

            if (Mediator.MediatorSearchBook.SearchBook() == 0)
            {
                booksInfo = booksInfo.Where(x => x.Title.Contains(s));
                return booksInfo.ToArray();
            }
            if (Mediator.MediatorSearchBook.SearchBook() == 1)
            {
                booksInfo = booksInfo.Where(x => x.AuthorFirstName.Contains(s));
                return booksInfo.ToArray();
            }
            if (Mediator.MediatorSearchBook.SearchBook() == 2)
            {
                booksInfo = booksInfo.Where(x => x.AuthorSecondName.Contains(s));
                return booksInfo.ToArray();
            }
            if (Mediator.MediatorSearchBook.SearchBook() == 3)
            {
                booksInfo = booksInfo.Where(x => x.Genre.Contains(s));
                return booksInfo.ToArray();
            }
            if (Mediator.MediatorSearchBook.SearchBook() == 4)
            {
                booksInfo = booksInfo.Where(x => x.PublishingYear.ToString().Contains(s));
                return booksInfo.ToArray();
            }
            return new List<BookInfo>();
        }
    }
}