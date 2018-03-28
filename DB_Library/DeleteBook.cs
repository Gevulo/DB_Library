using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    class DeleteBook
    {
        public void Delete(string d)
        {
            LibraryEntities le = new LibraryEntities();

            if (Mediator.MediatorDeleteBook.DeleteBook() == 0)
            {
                var q = (from x in le.Books where x.NameBook == d select x);
                if (q != null)
                {
                    //le.Books.RemoveRange();
                    le.SaveChanges();
                }
            }            
        }
    }
}
