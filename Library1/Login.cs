// --- File: Login.cs ---
using System;
using System.Drawing;
using System.Windows.Forms;
using Library1.DAL; // PENTING: Untuk mengakses DbManager

namespace Library1
{
    public partial class Login : Form
    {
        // Deklarasikan DbManager untuk akses database
        private readonly DbManager _dbManager = new DbManager();

        public Login()
        {
            InitializeComponent();
        }

        // Hapus tanda '?' dari 'object? sender'
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        // Hapus tanda '?' dari 'object? sender'
        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            // Logika saat teks username berubah (dibiarkan kosong)
        }

        // Hapus tanda '?' dari 'object? sender'
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Validasi Input Dasar
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nama pengguna dan kata sandi wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Menggunakan DbManager untuk Autentikasi
                bool isAuthenticated = _dbManager.AuthenticateAdmin(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show($"Selamat datang, {username}! Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // PENTING: Mengganti MainForm dengan FrmHome
                    FrmHome mainForm = new FrmHome();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nama pengguna atau kata sandi salah.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                // Tangani error database (misalnya, server mati)
                MessageBox.Show($"Gagal terhubung ke database. Detail: {ex.Message}", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}