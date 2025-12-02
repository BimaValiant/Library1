using System;
using System.Linq;
using System.Windows.Forms;
using Library1.DAL;
using Library1.Model;
using System.Collections.Generic;

namespace Library1
{
    public partial class FrmHome : Form
    {
        // Deklarasi DbManager untuk mengakses database
        // Asumsi: DbManager.cs sudah ada
        private readonly DbManager _dbManager = new DbManager();

        public FrmHome()
        {
            InitializeComponent();
            this.Text = "Home - Sistem Manajemen Perpustakaan";
        }

        // Event Load Form, dipanggil saat form pertama kali muncul
        private void FrmHome_Load_2(object sender, EventArgs e)
        {
            LoadDashboardMetrics();
            LoadActiveLoansList();
        }

        /// <summary>
        /// Memuat metrik (Total Buku, Pinjaman Aktif, dll.) dari database dan menampilkannya.
        /// </summary>
        private void LoadDashboardMetrics()
        {
            try
            {
                // Asumsi: Metode GetLibraryMetrics() mengembalikan objek yang berisi data metrik
                // LibraryMetrics metrics = _dbManager.GetLibraryMetrics(); 

                // MENGISI LABEL ANGKA DENGAN DATA (Contoh dummy jika DbManager belum siap)
                lblTotalBuku.Text = "1500"; // Contoh: metrics.TotalBuku.ToString();
                label3.Text = "500";       // Label di bawah panel Stok Tersedia
                label7.Text = "25";        // Label di bawah panel Pinjaman Aktif
                label5.Text = "5";         // Label di bawah panel Buku Terlambat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat metrik dashboard: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Memuat daftar peminjaman aktif dari database ke DataGridView (dgActiveLoans).
        /// </summary>
        private void LoadActiveLoansList()
        {
            try
            {
                // Asumsi: Metode GetActiveLoans() mengembalikan List<T> untuk diikat ke DataGridView
                // List<LoanDetail> loans = _dbManager.GetActiveLoans();

                // Jika DbManager belum ada, gunakan List dummy agar DataGridView tidak kosong
                var dummyData = new[]
                {
                    new { ID = 1, Buku = "Laskar Pelangi", Anggota = "Ani", JatuhTempo = "2025-12-05" },
                    new { ID = 2, Buku = "Bumi Manusia", Anggota = "Budi", JatuhTempo = "2025-12-10" },
                    new { ID = 3, Buku = "Perahu Kertas", Anggota = "Cici", JatuhTempo = "2025-12-01" },
                    new { ID = 4, Buku = "5 CM", Anggota = "Dian", JatuhTempo = "2025-12-15" },
                    new { ID = 5, Buku = "Ayat-Ayat Cinta", Anggota = "Eko", JatuhTempo = "2025-11-28" },
                    new { ID = 6, Buku = "Cantik Itu Luka", Anggota = "Fani", JatuhTempo = "2025-12-07" },
                    new { ID = 7, Buku = "Tenggelamnya Kapal Van Der Wijck", Anggota = "Gilang", JatuhTempo = "2025-12-20" },
                    new { ID = 8, Buku = "Aroma Karsa", Anggota = "Hani", JatuhTempo = "2025-11-25" },
                    new { ID = 9, Buku = "Dilan: Dia Adalah Dilanku Tahun 1990", Anggota = "Iwan", JatuhTempo = "2025-12-03" },
                    new { ID = 10, Buku = "The Hobbit", Anggota = "Joko", JatuhTempo = "2025-12-18" },
                    new { ID = 11, Buku = "Harry Potter and the Sorcerer's Stone", Anggota = "Kiki", JatuhTempo = "2025-12-22" },
                    new { ID = 12, Buku = "The Alchemist", Anggota = "Lia", JatuhTempo = "2025-11-30" },
                    new { ID = 13, Buku = "Da Vinci Code", Anggota = "Maman", JatuhTempo = "2025-12-06" },
                    new { ID = 14, Buku = "Pulang", Anggota = "Nina", JatuhTempo = "2025-12-11" },
                    new { ID = 15, Buku = "Negeri 5 Menara", Anggota = "Odi", JatuhTempo = "2025-12-16" },
                    new { ID = 16, Buku = "Laut Bercerita", Anggota = "Prita", JatuhTempo = "2025-12-24" },
                    new { ID = 17, Buku = "Garis Waktu", Anggota = "Qiqi", JatuhTempo = "2025-12-09" },
                    new { ID = 18, Buku = "Sapiens: A Brief History of Humankind", Anggota = "Rudy", JatuhTempo = "2025-12-04" },
                    new { ID = 19, Buku = "Filosofi Kopi", Anggota = "Santi", JatuhTempo = "2025-12-19" },
                    new { ID = 20, Buku = "Madre", Anggota = "Toni", JatuhTempo = "2025-12-14" }
                }.ToList();

                // Menghubungkan List ke DataGridView
                dgActiveLoans.DataSource = dummyData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat daftar pinjaman aktif: {ex.Message}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- EVENT HANDLER NAVIGASI ---

        private void MenuBuku_Click(object sender, EventArgs e)
        {
            // Logika untuk membuka Form Manajemen Buku
            // FrmBooks formBuku = new FrmBooks();
            // formBuku.Show();
            MessageBox.Show("Membuka Form Manajemen Buku...", "Navigasi");
        }

        private void MenuAnggota_Click(object sender, EventArgs e)
        {
            // Logika untuk membuka Form Manajemen Anggota
            // FrmMembers formAnggota = new FrmMembers();
            // formAnggota.Show();
            MessageBox.Show("Membuka Form Manajemen Anggota...", "Navigasi");
        }

        // Event handler yang dihasilkan Designer untuk Log Out
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menutup Form Home, yang akan mengakhiri aplikasi
            this.Close();
        }

        // --- Event handler yang tidak digunakan (dibiarkan agar tidak ada error CS1061) ---
        private void panelTotalBuku_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void panelStokTersedia_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void MenuBuku_Click_1(object sender, EventArgs e)
        {

        }
    }
}