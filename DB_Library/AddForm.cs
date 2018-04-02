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
    public partial class AddForm : MetroFramework.Forms.MetroForm
    {
        public AddForm()
        {
            InitializeComponent();

            //Медиатры для доступа к элементам формы из другога класса
            Mediator.MediatorAddBook.GetNameBook = () => this.textBox1.Text;            
            Mediator.MediatorAddBook.GetGenre = () => this.textBox4.Text;
            Mediator.MediatorAddBook.GetDate = () => int.Parse(this.textBox5.Text);
            Mediator.MediatorAddBook.GetCupboatd = () => int.Parse(this.textBox6.Text);
            Mediator.MediatorAddBook.GetShelf = () => int.Parse(this.textBox7.Text);

            MediatorLoadBook.GetName = () => { dynamic d = this.comboBox1.SelectedItem; return d.Row.Name; };
            MediatorLoadBook.GetSurname = () => { dynamic d = this.comboBox2.SelectedItem; return d.Row.Surname; };
        }                        
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddBook ab = new AddBook();
                ab.Add();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddAuthorBut_Click(object sender, EventArgs e)
        {
            try
            {
                AddAuthor aa = new AddAuthor();
                aa.ShowDialog();
                this.authorTableAdapter.Fill(this.dB_A37D63_LibraryDataSet.Author);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A37D63_LibraryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.dB_A37D63_LibraryDataSet.Author);
        }        
    }
}