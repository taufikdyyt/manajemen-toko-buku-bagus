using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookStoreManagement
{
    public partial class TambahEditBukuForm : Form
    {
        private bool isEditMode;
        private int bookId;

        public TambahEditBukuForm(bool isEditMode = false, int bookId = 0)
        {
            InitializeComponent();
            this.isEditMode = isEditMode;
            this.bookId = bookId;

            if (isEditMode)
            {
                LoadBookData();
            }
        }



        private void LoadBookData()
        {
            // Logic to load book data from database using bookId
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM books WHERE id=@id", connection);
                cmd.Parameters.AddWithValue("@id", bookId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTitle.Text = reader["title"].ToString();
                    txtAuthor.Text = reader["author"].ToString();
                    txtYear.Text = reader["year"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                }
            }



        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                MySqlCommand cmd;
                if (isEditMode)
                {
                    cmd = new MySqlCommand("UPDATE books SET title=@title, author=@authour, year=@year, price=@price WHERE id=@id", connection);
                    cmd.Parameters.AddWithValue("@id", bookId);
                }
                else
                {
                    cmd = new MySqlCommand("INSERT INTO books (title, author, year, price) VALUES (@title, @author, @year, @price)", connection);
                }

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}