namespace Biblioteka_KP
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
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkBoxSortType = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(-2, 2);
            this.dataGridViewCatalog.MultiSelect = false;
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.ReadOnly = true;
            this.dataGridViewCatalog.RowTemplate.Height = 25;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(412, 204);
            this.dataGridViewCatalog.TabIndex = 1;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(315, 213);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(95, 33);
            this.buttonAddBook.TabIndex = 2;
            this.buttonAddBook.Text = "Nowa książka";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(214, 212);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(95, 33);
            this.buttonAddAuthor.TabIndex = 3;
            this.buttonAddAuthor.Text = "Nowy autor";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.ItemHeight = 15;
            this.listBoxDescription.Location = new System.Drawing.Point(416, 2);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(378, 244);
            this.listBoxDescription.TabIndex = 4;
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Location = new System.Drawing.Point(699, 262);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(86, 39);
            this.buttonAddReview.TabIndex = 5;
            this.buttonAddReview.Text = "Dodaj recenzję";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            this.buttonAddReview.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(-2, 212);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Wyszukaj za pomocą tytułu lub autora";
            this.textBoxSearch.Size = new System.Drawing.Size(210, 33);
            this.textBoxSearch.TabIndex = 6;
            // 
            // checkBoxSortType
            // 
            this.checkBoxSortType.AutoSize = true;
            this.checkBoxSortType.Location = new System.Drawing.Point(-2, 282);
            this.checkBoxSortType.Name = "checkBoxSortType";
            this.checkBoxSortType.Size = new System.Drawing.Size(180, 19);
            this.checkBoxSortType.TabIndex = 7;
            this.checkBoxSortType.Text = "Sortowanie wg. ilości recenzji";
            this.checkBoxSortType.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxSortType);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewCatalog);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridViewCatalog;
        private Button buttonAddBook;
        private Button buttonAddAuthor;
        private ListBox listBoxDescription;
        private Button buttonAddReview;
        private TextBox textBoxSearch;
        private CheckBox checkBoxSortType;
    }
}