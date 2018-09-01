using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDatabase {
	public partial class Form1 : Form {
		DatabaseManager databaseManager;
		public Form1() {
			InitializeComponent();

			databaseManager = new DatabaseManager("datasource=127.0.0.1;port=3306;username=root;password=DataIT2018!;database=librarydatabase;SslMode=none;");
		}
		
		private void btnClear_Click(object sender, EventArgs e) {
			txbAuthor.Text = "";
			txbTitle.Text = "";
			txbISBN10.Text = "";
			txbISBN13.Text = "";
		}
		
		private void btbAdd_Click(object sender, EventArgs e) {
			databaseManager.AddBook(txbAuthor.Text, txbTitle.Text, txbISBN10.Text, txbISBN13.Text);

			txbAuthor.Text = "";
			txbTitle.Text = "";
			txbISBN10.Text = "";
			txbISBN13.Text = "";
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			if(txbSearchText.Text == "") {
				databaseManager.ListAll(lsbResults);
			}
			else {
				databaseManager.Search(lsbResults, cmbSearchTerm.SelectedIndex, txbSearchText.Text);
			}
		}
	}
}
