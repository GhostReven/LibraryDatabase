namespace LibraryDatabase
{
    partial class Form1
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
			this.lblSearchText = new System.Windows.Forms.Label();
			this.txbSearchText = new System.Windows.Forms.TextBox();
			this.cmbSearchTerm = new System.Windows.Forms.ComboBox();
			this.lblSearchTerm = new System.Windows.Forms.Label();
			this.lsbResults = new System.Windows.Forms.ListBox();
			this.lblResults = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.txbAuthor = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txbTitle = new System.Windows.Forms.TextBox();
			this.lblISBN10 = new System.Windows.Forms.Label();
			this.txbISBN10 = new System.Windows.Forms.TextBox();
			this.lblISBN13 = new System.Windows.Forms.Label();
			this.txbISBN13 = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btbAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSearchText
			// 
			this.lblSearchText.AutoSize = true;
			this.lblSearchText.Location = new System.Drawing.Point(13, 13);
			this.lblSearchText.Name = "lblSearchText";
			this.lblSearchText.Size = new System.Drawing.Size(61, 13);
			this.lblSearchText.TabIndex = 0;
			this.lblSearchText.Text = "Search text";
			// 
			// txbSearchText
			// 
			this.txbSearchText.Location = new System.Drawing.Point(13, 30);
			this.txbSearchText.Name = "txbSearchText";
			this.txbSearchText.Size = new System.Drawing.Size(100, 20);
			this.txbSearchText.TabIndex = 1;
			// 
			// cmbSearchTerm
			// 
			this.cmbSearchTerm.FormattingEnabled = true;
			this.cmbSearchTerm.Items.AddRange(new object[] {
            "Author",
            "Title",
            "ISBN-10",
            "ISBN-13"});
			this.cmbSearchTerm.Location = new System.Drawing.Point(120, 30);
			this.cmbSearchTerm.Name = "cmbSearchTerm";
			this.cmbSearchTerm.Size = new System.Drawing.Size(121, 21);
			this.cmbSearchTerm.TabIndex = 2;
			// 
			// lblSearchTerm
			// 
			this.lblSearchTerm.AutoSize = true;
			this.lblSearchTerm.Location = new System.Drawing.Point(120, 13);
			this.lblSearchTerm.Name = "lblSearchTerm";
			this.lblSearchTerm.Size = new System.Drawing.Size(64, 13);
			this.lblSearchTerm.TabIndex = 3;
			this.lblSearchTerm.Text = "Search term";
			// 
			// lsbResults
			// 
			this.lsbResults.FormattingEnabled = true;
			this.lsbResults.Location = new System.Drawing.Point(13, 79);
			this.lsbResults.Name = "lsbResults";
			this.lsbResults.Size = new System.Drawing.Size(771, 550);
			this.lsbResults.TabIndex = 4;
			// 
			// lblResults
			// 
			this.lblResults.AutoSize = true;
			this.lblResults.Location = new System.Drawing.Point(13, 63);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(42, 13);
			this.lblResults.TabIndex = 5;
			this.lblResults.Text = "Results";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(248, 30);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblAuthor
			// 
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Location = new System.Drawing.Point(787, 63);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(38, 13);
			this.lblAuthor.TabIndex = 7;
			this.lblAuthor.Text = "Author";
			// 
			// txbAuthor
			// 
			this.txbAuthor.Location = new System.Drawing.Point(790, 80);
			this.txbAuthor.Name = "txbAuthor";
			this.txbAuthor.Size = new System.Drawing.Size(206, 20);
			this.txbAuthor.TabIndex = 8;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(787, 103);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 13);
			this.lblTitle.TabIndex = 9;
			this.lblTitle.Text = "Title";
			// 
			// txbTitle
			// 
			this.txbTitle.Location = new System.Drawing.Point(790, 119);
			this.txbTitle.Name = "txbTitle";
			this.txbTitle.Size = new System.Drawing.Size(206, 20);
			this.txbTitle.TabIndex = 10;
			// 
			// lblISBN10
			// 
			this.lblISBN10.AutoSize = true;
			this.lblISBN10.Location = new System.Drawing.Point(787, 142);
			this.lblISBN10.Name = "lblISBN10";
			this.lblISBN10.Size = new System.Drawing.Size(47, 13);
			this.lblISBN10.TabIndex = 11;
			this.lblISBN10.Text = "ISBN-10";
			// 
			// txbISBN10
			// 
			this.txbISBN10.Location = new System.Drawing.Point(790, 158);
			this.txbISBN10.Name = "txbISBN10";
			this.txbISBN10.Size = new System.Drawing.Size(206, 20);
			this.txbISBN10.TabIndex = 12;
			// 
			// lblISBN13
			// 
			this.lblISBN13.AutoSize = true;
			this.lblISBN13.Location = new System.Drawing.Point(787, 185);
			this.lblISBN13.Name = "lblISBN13";
			this.lblISBN13.Size = new System.Drawing.Size(47, 13);
			this.lblISBN13.TabIndex = 13;
			this.lblISBN13.Text = "ISBN-13";
			// 
			// txbISBN13
			// 
			this.txbISBN13.Location = new System.Drawing.Point(790, 202);
			this.txbISBN13.Name = "txbISBN13";
			this.txbISBN13.Size = new System.Drawing.Size(206, 20);
			this.txbISBN13.TabIndex = 14;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(790, 229);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btbAdd
			// 
			this.btbAdd.Location = new System.Drawing.Point(920, 229);
			this.btbAdd.Name = "btbAdd";
			this.btbAdd.Size = new System.Drawing.Size(75, 23);
			this.btbAdd.TabIndex = 16;
			this.btbAdd.Text = "Add";
			this.btbAdd.UseVisualStyleBackColor = true;
			this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 681);
			this.Controls.Add(this.btbAdd);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txbISBN13);
			this.Controls.Add(this.lblISBN13);
			this.Controls.Add(this.txbISBN10);
			this.Controls.Add(this.lblISBN10);
			this.Controls.Add(this.txbTitle);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txbAuthor);
			this.Controls.Add(this.lblAuthor);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.lblResults);
			this.Controls.Add(this.lsbResults);
			this.Controls.Add(this.lblSearchTerm);
			this.Controls.Add(this.cmbSearchTerm);
			this.Controls.Add(this.txbSearchText);
			this.Controls.Add(this.lblSearchText);
			this.Name = "Form1";
			this.Text = "LibraryDatabase";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.TextBox txbSearchText;
        private System.Windows.Forms.ComboBox cmbSearchTerm;
        private System.Windows.Forms.Label lblSearchTerm;
        private System.Windows.Forms.ListBox lsbResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label lblISBN10;
        private System.Windows.Forms.TextBox txbISBN10;
        private System.Windows.Forms.Label lblISBN13;
        private System.Windows.Forms.TextBox txbISBN13;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btbAdd;
    }
}

