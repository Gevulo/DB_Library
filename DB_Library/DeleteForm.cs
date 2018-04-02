using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Library
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            Mediator.MediatorDeleteBook.DeleteBook = () => this.comboBox1.SelectedIndex;
            Mediator.MediatorDeleteBook.DeleteBookText = () => this.textBox1.Text;
        }
        private void DeleteBut_Click(object sender, EventArgs e)
        {
            try
            {
                string d = Mediator.MediatorDeleteBook.DeleteBookText();
                DeleteBook db = new DeleteBook();
                db.DeleteBoo(d);

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
                    }).ToList();

                Mediator.MediatorDeleteBook.LoadBook(booksInfo.ToArray());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}