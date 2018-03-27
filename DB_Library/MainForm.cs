using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient; //
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Library
{
    public partial class MainForm : Form
    {        
        string connection = "Data Source=SQL6004.site4now.net;Initial Catalog=DB_A37D63_Library;User Id=DB_A37D63_Library_admin;Password=A2345678;"; //
        public MainForm()
        {
            InitializeComponent();                        
        }
        
        private void MainForm_Load(object sender, EventArgs e) 
        {
            using(SqlConnection con = new SqlConnection(connection))
            {
                SqlDataReader reader=null;
                List<string[]> data = new List<string[]>();
                try
                {
                    con.Open();

                    SqlCommand comandString = new SqlCommand(@"SELECT NameBook, Year, Gener, Name, Surname                                                               
                                                               FROM Books
                                                               RIGHT JOIN
                                                               Author
                                                               ON Books.id_Author =  Author.id", con);
                    reader = comandString.ExecuteReader();

                    while(reader.Read())
                    {
                        data.Add(new string[7]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                    }
                    reader.Close();
                    foreach(string[] str in data)
                    {
                        this.dataGridView1.DataSource = str.ToArray();
                        //
                        //
                        //
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void AddBookBut_Click(object sender, EventArgs e)
        {
            try
            {

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