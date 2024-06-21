using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Mengatur Form1 sebagai MDI container
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tambahBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Logika untuk membuka form Tambah Buku
            TambahEditBukuForm tambahBukuForm = new TambahEditBukuForm();
            tambahBukuForm.MdiParent = this;
            tambahBukuForm.Show();
        }

        private void lihatBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Logika untuk membuka form Lihat Buku
            BukuForm lihatBukuForm = new BukuForm();
            lihatBukuForm.MdiParent = this;
            lihatBukuForm.Show();
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi Manajemen Toko Buku versi 1.0", "Tentang");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}
