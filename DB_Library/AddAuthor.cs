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
    public partial class AddAuthor : MetroFramework.Forms.MetroForm
    {
        public AddAuthor()
        {
            InitializeComponent();
        }
        private void AddAuth_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryEntities le = new LibraryEntities();

                var ath = new Author
                {
                    Name = this.textBox1.Text.ToString(),
                    Surname = this.textBox2.Text.ToString()
                };

                le.Author.Add(ath);
                le.SaveChanges();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
