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
            try
            {
                var le = new LibraryEntities();
                var ath = new Author();
                var lib = new Librar();

                var name = MediatorLoadBook.GetName();
                var surname = MediatorLoadBook.GetSurname();

                var bk = new Books
                {
                    NameBook = Mediator.MediatorAddBook.GetNameBook(),
                    Gener = Mediator.MediatorAddBook.GetGenre(),
                    Year = Mediator.MediatorAddBook.GetDate()
                };

                var NomberShelf = Mediator.MediatorAddBook.GetShelf();
                var NomberCupboard = Mediator.MediatorAddBook.GetCupboatd();

                ath = le.Author.FirstOrDefault(x => x.Name == name && x.Surname == surname);
                bk.id_Author = ath.id;

                var c = le.Librar.FirstOrDefault(x => x.NomberCupboard == lib.NomberCupboard && x.NomberShelf == lib.NomberShelf);

                if (c == null)
                {
                    le.Librar.Add(lib);

                    lib = le.Librar.FirstOrDefault(x => x.NomberCupboard == NomberCupboard && x.NomberShelf == NomberShelf);
                    bk.id_Librar = lib.id;
                    le.SaveChanges();
                }
                else
                {
                    bk.id_Librar = c.id;
                    le.SaveChanges();
                }

                le.Books.Add(bk);
                le.SaveChanges();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}