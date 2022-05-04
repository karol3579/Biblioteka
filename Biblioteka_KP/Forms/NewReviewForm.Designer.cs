namespace Biblioteka_KP.Forms
{
    partial class NewReviewForm
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(41, 73);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(415, 176);
            this.textBoxDescription.TabIndex = 0;
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxValue.Location = new System.Drawing.Point(41, 26);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(121, 23);
            this.comboBoxValue.TabIndex = 1;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(41, 9);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(44, 15);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Ocena:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(41, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(64, 15);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Komentarz";
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Location = new System.Drawing.Point(381, 255);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(75, 23);
            this.buttonAddReview.TabIndex = 4;
            this.buttonAddReview.Text = "Dodaj";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            // 
            // NewReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 304);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "NewReviewForm";
            this.Text = "NewReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDescription;
        private ComboBox comboBoxValue;
        private Label labelValue;
        private Label labelDescription;
        private Button buttonAddReview;
    }
}