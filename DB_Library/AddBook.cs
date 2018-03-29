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

            var c = le.Librar.FirstOrDefault(x => x.NomberCupboard == lib.NomberCupboard && x.NomberShelf == lib.NomberShelf);
            if (c == null)
            {
                le.Librar.Add(lib);
                le.SaveChanges();
                lib = le.Librar.FirstOrDefault(x => x.NomberCupboard == lib.NomberCupboard && x.NomberShelf == lib.NomberShelf);
            }            
            bk.id_Librar = lib.id;        
            
            le.Books.Add(bk);            
            le.SaveChanges();
        }
    }
}