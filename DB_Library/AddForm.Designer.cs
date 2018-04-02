namespace DB_Library
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A37D63_LibraryDataSet = new DB_Library.DB_A37D63_LibraryDataSet();
            this.authorTableAdapter = new DB_Library.DB_A37D63_LibraryDataSetTableAdapters.AuthorTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textBox5 = new MetroFramework.Controls.MetroTextBox();
            this.textBox6 = new MetroFramework.Controls.MetroTextBox();
            this.textBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox2 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A37D63_LibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.dB_A37D63_LibraryDataSet;
            // 
            // dB_A37D63_LibraryDataSet
            // 
            this.dB_A37D63_LibraryDataSet.DataSetName = "DB_A37D63_LibraryDataSet";
            this.dB_A37D63_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Название книги";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Имя автора";
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(389, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(24, 49);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(411, 23);
            this.textBox1.TabIndex = 35;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Фамилия автора";
            // 
            // textBox4
            // 
            // 
            // 
            // 
            this.textBox4.CustomButton.Image = null;
            this.textBox4.CustomButton.Location = new System.Drawing.Point(389, 1);
            this.textBox4.CustomButton.Name = "";
            this.textBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox4.CustomButton.TabIndex = 1;
            this.textBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox4.CustomButton.UseSelectable = true;
            this.textBox4.CustomButton.Visible = false;
            this.textBox4.Lines = new string[0];
            this.textBox4.Location = new System.Drawing.Point(23, 185);
            this.textBox4.MaxLength = 32767;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '\0';
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox4.SelectedText = "";
            this.textBox4.SelectionLength = 0;
            this.textBox4.SelectionStart = 0;
            this.textBox4.ShortcutsEnabled = true;
            this.textBox4.Size = new System.Drawing.Size(411, 23);
            this.textBox4.TabIndex = 37;
            this.textBox4.UseSelectable = true;
            this.textBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Жанр";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Дата издания";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.TabIndex = 40;
            this.metroLabel6.Text = "Номер шкафа";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(227, 256);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Полка";
            // 
            // textBox5
            // 
            // 
            // 
            // 
            this.textBox5.CustomButton.Image = null;
            this.textBox5.CustomButton.Location = new System.Drawing.Point(389, 1);
            this.textBox5.CustomButton.Name = "";
            this.textBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox5.CustomButton.TabIndex = 1;
            this.textBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox5.CustomButton.UseSelectable = true;
            this.textBox5.CustomButton.Visible = false;
            this.textBox5.Lines = new string[0];
            this.textBox5.Location = new System.Drawing.Point(23, 230);
            this.textBox5.MaxLength = 32767;
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '\0';
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox5.SelectedText = "";
            this.textBox5.SelectionLength = 0;
            this.textBox5.SelectionStart = 0;
            this.textBox5.ShortcutsEnabled = true;
            this.textBox5.Size = new System.Drawing.Size(411, 23);
            this.textBox5.TabIndex = 42;
            this.textBox5.UseSelectable = true;
            this.textBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox6
            // 
            // 
            // 
            // 
            this.textBox6.CustomButton.Image = null;
            this.textBox6.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.textBox6.CustomButton.Name = "";
            this.textBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox6.CustomButton.TabIndex = 1;
            this.textBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox6.CustomButton.UseSelectable = true;
            this.textBox6.CustomButton.Visible = false;
            this.textBox6.Lines = new string[0];
            this.textBox6.Location = new System.Drawing.Point(23, 278);
            this.textBox6.MaxLength = 32767;
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '\0';
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox6.SelectedText = "";
            this.textBox6.SelectionLength = 0;
            this.textBox6.SelectionStart = 0;
            this.textBox6.ShortcutsEnabled = true;
            this.textBox6.Size = new System.Drawing.Size(198, 23);
            this.textBox6.TabIndex = 43;
            this.textBox6.UseSelectable = true;
            this.textBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox7
            // 
            // 
            // 
            // 
            this.textBox7.CustomButton.Image = null;
            this.textBox7.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.textBox7.CustomButton.Name = "";
            this.textBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox7.CustomButton.TabIndex = 1;
            this.textBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox7.CustomButton.UseSelectable = true;
            this.textBox7.CustomButton.Visible = false;
            this.textBox7.Lines = new string[0];
            this.textBox7.Location = new System.Drawing.Point(227, 278);
            this.textBox7.MaxLength = 32767;
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '\0';
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox7.SelectedText = "";
            this.textBox7.SelectionLength = 0;
            this.textBox7.SelectionStart = 0;
            this.textBox7.ShortcutsEnabled = true;
            this.textBox7.Size = new System.Drawing.Size(207, 23);
            this.textBox7.TabIndex = 44;
            this.textBox7.UseSelectable = true;
            this.textBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(359, 313);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(376, 118);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(58, 23);
            this.metroButton2.TabIndex = 46;
            this.metroButton2.Text = "Add";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.AddAuthorBut_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.authorBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(23, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 29);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.UseSelectable = true;
            this.comboBox1.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.authorBindingSource;
            this.comboBox2.DisplayMember = "Surname";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 23;
            this.comboBox2.Location = new System.Drawing.Point(24, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(347, 29);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.UseSelectable = true;
            this.comboBox2.ValueMember = "id";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 359);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A37D63_LibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_A37D63_LibraryDataSet dB_A37D63_LibraryDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private DB_A37D63_LibraryDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textBox4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox textBox5;
        private MetroFramework.Controls.MetroTextBox textBox6;
        private MetroFramework.Controls.MetroTextBox textBox7;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroComboBox comboBox2;
    }
}