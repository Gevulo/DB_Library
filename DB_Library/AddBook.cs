using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    class AddBook
    {
        public void Add()
        {
            var ab = new LibraryEntities();
            var bk = new Books
            {
                NameBook = Mediator.MediatorAddBook.GetNameBook(),
                Gener = Mediator.MediatorAddBook.GetGenre(),
                Year = Mediator.MediatorAddBook.GetDate()        
            };

            var ath = new Author
            {
                Name = Mediator.MediatorAddBook.GetFirstName(),
                Surname = Mediator.MediatorAddBook.GetSecondName()            
            };

            var lib = new Librar
            {
                NomberShelf = Mediator.MediatorAddBook.GetShelf(),
                NomberCupboard = Mediator.MediatorAddBook.GetCupboatd()
            };

            ab.Books.Add(bk);
            ab.Author.Add(ath);
            ab.Librar.Add(lib);

            ab.SaveChanges();
        }        
    }
}