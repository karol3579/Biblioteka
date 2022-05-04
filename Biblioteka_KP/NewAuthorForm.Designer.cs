namespace Biblioteka_KP
{
    partial class NewAuthorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.labelErrorAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(76, 54);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 29);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.UseSystemPasswordChar = true;
            this.textBoxFirstName.WordWrap = false;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(76, 120);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(136, 29);
            this.textBoxLastName.TabIndex = 3;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(137, 178);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuthor.TabIndex = 4;
            this.buttonAddAuthor.Text = "Dodaj";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            // 
            // labelErrorAuthor
            // 
            this.labelErrorAuthor.AutoSize = true;
            this.labelErrorAuthor.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAuthor.Location = new System.Drawing.Point(95, 229);
            this.labelErrorAuthor.Name = "labelErrorAuthor";
            this.labelErrorAuthor.Size = new System.Drawing.Size(0, 15);
            this.labelErrorAuthor.TabIndex = 5;
            // 
            // NewAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 293);
            this.Controls.Add(this.labelErrorAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewAuthorForm";
            this.Text = "NewAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Button buttonAddAuthor;
        private Label labelErrorAuthor;
    }
}