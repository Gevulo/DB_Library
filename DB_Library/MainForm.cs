﻿using System;
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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            Mediator.MediatorSearchBook.SearchBook = () => this.comboBox1.SelectedIndex;
            MediatorLoadBook.GetBooks = () => this.dataGridView1.Rows;
            Mediator.MediatorDeleteBook.LoadBook = (x) => this.dataGridView1.DataSource = x;
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
               this.dataGridView1.DataSource = SearchBook.Search(this.textBox1.Text);
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LibraryEntities le = new LibraryEntities();
                List<BookInfo> a = new List<BookInfo>(le.Books.Select(x => new BookInfo() { AuthorFirstName = x.Author.Name, AuthorSecondName = x.Author.Surname, Genre = x.Gener, PublishingYear = x.Year, Title = x.NameBook }));
               

                this.dataGridView1.DataSource = a;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
} 