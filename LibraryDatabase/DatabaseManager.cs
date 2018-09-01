using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryDatabase {
	class DatabaseManager {
		string myConnectionString;

		public DatabaseManager(string connectionString) {
			myConnectionString = connectionString;
		}

		public void AddBook(string author, string title, string isbn10, string isbn13) {
			string query = "INSERT INTO books(`title`,`author`,`isbn10`,`isbn13`) VALUES ('" + title + "', '" + author + "', '" + isbn10 + "', '" + isbn13 + "')";

			MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection) {
				CommandTimeout = 60
			};

			try {
				databaseConnection.Open();
				MySqlDataReader myReader = commandDatabase.ExecuteReader();

				MessageBox.Show("Book added succesfully.");

				databaseConnection.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		public void ListAll(ListBox listBox) {
			string query = "SELECT * FROM books";

			MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection) {
				CommandTimeout = 60
			};
			MySqlDataReader reader;

			try {
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();

				listBox.Items.Clear();

				if (reader.HasRows) {
					while(reader.Read()) {
						listBox.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetString(3));
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		public void Search(ListBox listBox, int index, string searchText) {
			string searchTerm;
			switch (index) {
				case 0:
					searchTerm = "author";
					break;
				case 1:
					searchTerm = "title";
					break;
				case 2:
					searchTerm = "isbn10";
					break;
				case 3:
					searchTerm = "isbn13";
					break;
				default:
					searchTerm = "";
					break;
			}

			string query = "SELECT * FROM books WHERE " + searchTerm + " like '%" + searchText + "%'";

			MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection) {
				CommandTimeout = 60
			};
			MySqlDataReader reader;

			try {
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();

				listBox.Items.Clear();

				if (reader.HasRows) {
					while (reader.Read()) {
						listBox.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2) + "\t" + reader.GetString(3));
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
