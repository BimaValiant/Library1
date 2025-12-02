// --- File: FrmBuku.cs ---
using System;
using System.Linq;
using System.Windows.Forms;
using Library1.DAL;
using Library1.Model;
using System.Collections.Generic;

namespace Library1
{
    public partial class FrmBuku : Form
    {
        // Asumsi DbManager berada di DAL dan sudah bisa diakses
        private readonly DbManager _dbManager = new DbManager();
        private TextBox txtJudul;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtPenulis;
        private TextBox txtISBN;
        private TextBox txtStok;
        private DataGridView dgvBuku;
        private Button btnSimpan;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnBatal;
        private int _selectedBukuId = 0; // Untuk menyimpan ID buku yang dipilih

        public FrmBuku()
        {
            InitializeComponent();
            this.Text = "Manajemen Data Buku";
            // Pastikan Anda menonaktifkan tombol ubah dan hapus secara default
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            LoadDataBuku();
        }

        /// <summary>
        /// Memuat semua data buku dari database dan menampilkannya di dgvBuku.
        /// </summary>
        private void LoadDataBuku()
        {
            try
            {
                // Asumsi: DbManager.GetAllBuku() sudah diimplementasikan
                // List<Buku> daftarBuku = _dbManager.GetAllBuku();

                // --- GUNAKAN DUMMY DATA JIKA DAL BELUM SIAP ---
                var daftarBuku = new List<Buku>
                {
                    new Buku { BukuID = 1, Judul = "Laskar Pelangi", Penulis = "Andrea Hirata", ISBN = "978-6029141045", Stok = 10 },
                    new Buku { BukuID = 2, Judul = "Bumi Manusia", Penulis = "Pramoedya", ISBN = "978-9799731238", Stok = 5 }
                };
                // --- END DUMMY DATA ---

                dgvBuku.DataSource = daftarBuku;

                // Sembunyikan ID jika diperlukan
                if (dgvBuku.Columns.Contains("BukuID"))
                    dgvBuku.Columns["BukuID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data buku: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Dipanggil saat baris di DataGridView diklik untuk mengisi form.
        /// </summary>
        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris yang diklik valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBuku.Rows[e.RowIndex];

                // Ambil ID Buku dan isi TextBox
                _selectedBukuId = Convert.ToInt32(row.Cells["BukuID"].Value);
                txtJudul.Text = row.Cells["Judul"].Value.ToString();
                txtPenulis.Text = row.Cells["Penulis"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtStok.Text = row.Cells["Stok"].Value.ToString();

                // Aktifkan mode Edit/Delete
                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        /// <summary>
        /// Menyimpan data buku baru.
        /// </summary>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Buku bukuBaru = new Buku
            {
                Judul = txtJudul.Text,
                Penulis = txtPenulis.Text,
                ISBN = txtISBN.Text,
                Stok = Convert.ToInt32(txtStok.Text)
            };

            try
            {
                // Panggil _dbManager.AddBuku(bukuBaru);
                MessageBox.Show("Data buku berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDataBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Memperbarui data buku yang sudah ada.
        /// </summary>
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (_selectedBukuId == 0 || !ValidateInput()) return;

            Buku bukuUpdate = new Buku
            {
                BukuID = _selectedBukuId,
                Judul = txtJudul.Text,
                Penulis = txtPenulis.Text,
                ISBN = txtISBN.Text,
                Stok = Convert.ToInt32(txtStok.Text)
            };

            try
            {
                // Panggil _dbManager.UpdateBuku(bukuUpdate);
                MessageBox.Show("Data buku berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDataBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengubah data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Menghapus data buku.
        /// </summary>
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedBukuId == 0) return;

            DialogResult result = MessageBox.Show("Yakin hapus buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Panggil _dbManager.DeleteBuku(_selectedBukuId);
                    MessageBox.Show("Data buku berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDataBuku();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menghapus data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Mengatur ulang form.
        /// </summary>
        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Fungsi pembantu untuk membersihkan form.
        /// </summary>
        private void ClearForm()
        {
            txtJudul.Clear();
            txtPenulis.Clear();
            txtISBN.Clear();
            txtStok.Clear();
            _selectedBukuId = 0;

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            txtJudul.Focus();
        }

        /// <summary>
        /// Validasi input wajib dan tipe data.
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text) || string.IsNullOrWhiteSpace(txtPenulis.Text) || string.IsNullOrWhiteSpace(txtISBN.Text) || string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Semua kolom wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtStok.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa angka positif.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void InitializeComponent()
        {
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(124, 102);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(100, 22);
            this.txtJudul.TabIndex = 0;
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(124, 160);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(100, 22);
            this.txtPenulis.TabIndex = 1;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(124, 216);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 2;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(124, 267);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 3;
            this.txtStok.TextChanged += new System.EventHandler(this.p_TextChanged);
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(242, 102);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.RowHeadersWidth = 51;
            this.dgvBuku.RowTemplate.Height = 24;
            this.dgvBuku.Size = new System.Drawing.Size(353, 187);
            this.dgvBuku.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(242, 326);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(336, 326);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 6;
            this.btnUbah.Text = "UBAH";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(428, 326);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(520, 326);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click_1);
            // 
            // FrmBuku
            // 
            this.ClientSize = new System.Drawing.Size(732, 426);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dgvBuku);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.txtJudul);
            this.Name = "FrmBuku";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void p_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

        }

        // --- Tambahkan event handler lain yang dibuat oleh Designer di sini ---
    }
}