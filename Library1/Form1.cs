using System;
using System.Windows.Forms;
using Library1.DAL;

namespace Library1
{
    public partial class Form1 : Form // Harus partial
    {
        private readonly DbManager _dbManager = new DbManager();

        public Form1()
        {
            InitializeComponent(); // HANYA PANGGILAN
            this.Text = "Login Perpustakaan";
            txtPassword.PasswordChar = '1';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_dbManager.AuthenticateAdmin(username, password))
                {
                    MessageBox.Show("Login Berhasil! Selamat datang, Admin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FrmHome homeForm = new FrmHome();
                    homeForm.Show();
                    homeForm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah.", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan database: {ex.Message}", "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}