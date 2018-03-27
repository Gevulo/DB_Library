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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddBookBut_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm af = new AddForm();
                af.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteBookBut_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteForm df = new DeleteForm();
                df.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadBookBut_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm lf = new LoadForm();
                lf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchBooksButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AboutBut_Click(object sender, EventArgs e)
        {
            try
            {
                AboutForm abForm = new AboutForm();
                abForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}