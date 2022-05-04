namespace Biblioteka_KP.Forms
{
    partial class NewBookForm
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
            this.buttonCreateNewBook = new System.Windows.Forms.Button();
            this.textBookTitle = new System.Windows.Forms.TextBox();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelWrongAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateNewBook
            // 
            this.buttonCreateNewBook.Location = new System.Drawing.Point(155, 162);
            this.buttonCreateNewBook.Name = "buttonCreateNewBook";
            this.buttonCreateNewBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateNewBook.TabIndex = 0;
            this.buttonCreateNewBook.Text = "Dodaj";
            this.buttonCreateNewBook.UseVisualStyleBackColor = true;
            // 
            // textBookTitle
            // 
            this.textBookTitle.Location = new System.Drawing.Point(60, 58);
            this.textBookTitle.Multiline = true;
            this.textBookTitle.Name = "textBookTitle";
            this.textBookTitle.Size = new System.Drawing.Size(170, 26);
            this.textBookTitle.TabIndex = 1;
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(60, 111);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(170, 23);
            this.comboBoxAuthors.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(60, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 15);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Tytuł";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(60, 93);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(37, 15);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Autor";
            // 
            // labelWrongAuthor
            // 
            this.labelWrongAuthor.AutoSize = true;
            this.labelWrongAuthor.ForeColor = System.Drawing.Color.Red;
            this.labelWrongAuthor.Location = new System.Drawing.Point(87, 206);
            this.labelWrongAuthor.Name = "labelWrongAuthor";
            this.labelWrongAuthor.Size = new System.Drawing.Size(119, 15);
            this.labelWrongAuthor.TabIndex = 5;
            this.labelWrongAuthor.Text = "Nie wskazano autora!";
            this.labelWrongAuthor.Visible = false;
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 278);
            this.Controls.Add(this.labelWrongAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.textBookTitle);
            this.Controls.Add(this.buttonCreateNewBook);
            this.Name = "NewBookForm";
            this.Text = "NewBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCreateNewBook;
        private TextBox textBookTitle;
        private ComboBox comboBoxAuthors;
        private Label labelTitle;
        private Label labelAuthor;
        private Label labelWrongAuthor;
    }
}