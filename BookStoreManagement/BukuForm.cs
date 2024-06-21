using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookStoreManagement
{
    public partial class BukuForm : Form
    {
        public BukuForm()
        {
            InitializeComponent();
            LoadBookData();
        }

        private void LoadBookData()
        {
            using (var connection = new Database().GetConnection())
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM books", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TambahEditBukuForm tambahBukuForm = new TambahEditBukuForm();
            tambahBukuForm.FormClosed += (s, args) => LoadBookData();
            tambahBukuForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bookId = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                TambahEditBukuForm editBukuForm = new TambahEditBukuForm(true, bookId);
                editBukuForm.FormClosed += (s, args) => LoadBookData();
                editBukuForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin diedit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bookId = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;

                using (var connection = new Database().GetConnection())
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM books WHERE id=@id", connection);
                    cmd.Parameters.AddWithValue("@id", bookId);
                    cmd.ExecuteNonQuery();
                }

                LoadBookData();
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dihapus.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BukuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
