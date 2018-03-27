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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

            //Медиатры для доступа к элементам формы из другога класса
            Mediator.MediatorAddBook.GetNameBook = () => this.textBox1.Text;
            Mediator.MediatorAddBook.GetFirstName = () => this.textBox2.Text;
            Mediator.MediatorAddBook.GetSecondName = () => this.textBox3.Text;
            Mediator.MediatorAddBook.GetGenre = () => this.textBox4.Text;
            Mediator.MediatorAddBook.GetDate = () => int.Parse(this.textBox5.Text);
            Mediator.MediatorAddBook.GetCupboatd = () => int.Parse(this.textBox6.Text);
            Mediator.MediatorAddBook.GetShelf = () => int.Parse(this.textBox7.Text);
            
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
    }
}