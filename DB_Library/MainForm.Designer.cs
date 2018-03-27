namespace DB_Library
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchBooksButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AboutBut = new System.Windows.Forms.Button();
            this.LoadBookBut = new System.Windows.Forms.Button();
            this.DeleteBookBut = new System.Windows.Forms.Button();
            this.AddBookBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 402);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SearchBooksButton);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры поиска";
            // 
            // SearchBooksButton
            // 
            this.SearchBooksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBooksButton.Location = new System.Drawing.Point(754, 19);
            this.SearchBooksButton.Name = "SearchBooksButton";
            this.SearchBooksButton.Size = new System.Drawing.Size(181, 64);
            this.SearchBooksButton.TabIndex = 5;
            this.SearchBooksButton.Text = "Поиск";
            this.SearchBooksButton.UseVisualStyleBackColor = true;
            this.SearchBooksButton.Click += new System.EventHandler(this.SearchBooksButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(473, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Искомое значения";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Название",
            "Имя автора",
            "Фамилия автора",
            "Жанр",
            "Дата издания"});
            this.comboBox1.Location = new System.Drawing.Point(127, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр поиска";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AboutBut);
            this.groupBox1.Controls.Add(this.LoadBookBut);
            this.groupBox1.Controls.Add(this.DeleteBookBut);
            this.groupBox1.Controls.Add(this.AddBookBut);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // AboutBut
            // 
            this.AboutBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutBut.Location = new System.Drawing.Point(754, 19);
            this.AboutBut.Name = "AboutBut";
            this.AboutBut.Size = new System.Drawing.Size(181, 64);
            this.AboutBut.TabIndex = 4;
            this.AboutBut.Text = "О Авторе";
            this.AboutBut.UseVisualStyleBackColor = true;
            this.AboutBut.Click += new System.EventHandler(this.AboutBut_Click);
            // 
            // LoadBookBut
            // 
            this.LoadBookBut.Location = new System.Drawing.Point(380, 19);
            this.LoadBookBut.Name = "LoadBookBut";
            this.LoadBookBut.Size = new System.Drawing.Size(181, 64);
            this.LoadBookBut.TabIndex = 3;
            this.LoadBookBut.Text = "Загрузка в файл";
            this.LoadBookBut.UseVisualStyleBackColor = true;
            this.LoadBookBut.Click += new System.EventHandler(this.LoadBookBut_Click);
            // 
            // DeleteBookBut
            // 
            this.DeleteBookBut.Location = new System.Drawing.Point(193, 19);
            this.DeleteBookBut.Name = "DeleteBookBut";
            this.DeleteBookBut.Size = new System.Drawing.Size(181, 64);
            this.DeleteBookBut.TabIndex = 2;
            this.DeleteBookBut.Text = "Удалить книгу";
            this.DeleteBookBut.UseVisualStyleBackColor = true;
            this.DeleteBookBut.Click += new System.EventHandler(this.DeleteBookBut_Click);
            // 
            // AddBookBut
            // 
            this.AddBookBut.Location = new System.Drawing.Point(6, 19);
            this.AddBookBut.Name = "AddBookBut";
            this.AddBookBut.Size = new System.Drawing.Size(181, 64);
            this.AddBookBut.TabIndex = 0;
            this.AddBookBut.Text = "Добавить книгу";
            this.AddBookBut.UseVisualStyleBackColor = true;
            this.AddBookBut.Click += new System.EventHandler(this.AddBookBut_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Книги";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchBooksButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AboutBut;
        private System.Windows.Forms.Button LoadBookBut;
        private System.Windows.Forms.Button DeleteBookBut;
        private System.Windows.Forms.Button AddBookBut;
        private System.Windows.Forms.Label label4;
    }
}