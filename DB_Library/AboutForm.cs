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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            try
            {
                InitializeComponent();
                string a = ("Author: \n\tVersion: 0.4".ToString());
                this.textBox1.Text = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
