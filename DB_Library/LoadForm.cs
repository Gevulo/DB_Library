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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            Mediator.MediatorLoadBook.GetNameFile = () => this.textBox1.Text;
        }
        private void LoadBut_Click(object sender, EventArgs e)
        {
            try
            {
                LoadBook lb = new LoadBook();
                lb.Load();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}