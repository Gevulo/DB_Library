using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    class DeleteBook
    {
        public void DeleteBoo(string d)
        {
            try
            {
                LibraryEntities le = new LibraryEntities();
                var bk = new Books();

                if (Mediator.MediatorDeleteBook.DeleteBook() == 0)
                {                 
                    bk = le.Books.FirstOrDefault(x => x.NameBook == d);                    
                    if (bk != null)
                    {
                        le.Books.Remove(bk);
                        le.SaveChanges();
                    }
                }

                if (Mediator.MediatorDeleteBook.DeleteBook() == 1)
                {
                    bk = le.Books.FirstOrDefault(x => x.Gener == d);
                    if (bk != null)
                    {
                        le.Books.Remove(bk);
                        le.SaveChanges();
                    }
                }                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}