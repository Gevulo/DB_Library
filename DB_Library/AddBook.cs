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
            var le = new LibraryEntities();
            var ath = new Author();

            var name = MediatorLoadBook.GetName();
            var surname = MediatorLoadBook.GetSurname();

            var bk = new Books
            {
                NameBook = Mediator.MediatorAddBook.GetNameBook(),
                Gener = Mediator.MediatorAddBook.GetGenre(),
                Year = Mediator.MediatorAddBook.GetDate()
            };            

            var lib = new Librar
            {
                NomberShelf = Mediator.MediatorAddBook.GetShelf(),
                NomberCupboard = Mediator.MediatorAddBook.GetCupboatd()
            };            
            
            ath = le.Author.FirstOrDefault(x => x.Name == name && x.Surname == surname);
            bk.id_Author = ath.id;

            var c = le.Librar.FirstOrDefault(x => x.NomberCupboard == lib.NomberCupboard && x.NomberShelf == lib.NomberShelf);            

            if (c == null)
            {
                le.Librar.Add(lib);
                lib = le.Librar.FirstOrDefault(x => x.NomberCupboard == lib.NomberCupboard && x.NomberShelf == lib.NomberShelf);                
                le.SaveChanges();
            }
            else
            {
                bk.id_Librar = c.id;                
            }            

            le.Books.Add(bk);            
            le.SaveChanges();
        }
    }
}