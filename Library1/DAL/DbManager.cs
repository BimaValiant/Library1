// --- File: DAL/DbManager.cs ---
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Library1.Model;
using System.Configuration; // PENTING: Untuk menggunakan ConfigurationManager

namespace Library1.DAL
{
    public class DbManager
    {
        // Mendapatkan Connection String dari App.config (Lebih Fleksibel)
        // Pastikan Anda telah menambahkan referensi System.Configuration ke proyek Anda!
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["PerpusDBConn"].ConnectionString;


        // --- 1. Autentikasi Admin (Untuk Login) ---
        public bool AuthenticateAdmin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM ADMINS WHERE Username = @Username AND PasswordHash = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int result = (int)command.ExecuteScalar();
                return result == 1;
            }
        }

        // --- 2. Pengambilan Metrik Dashboard (Untuk FrmHome) ---
        public LibraryMetrics GetLibraryMetrics()
        {
            var metrics = new LibraryMetrics();
            string query = @"
                SELECT  
                    (SELECT ISNULL(COUNT(*), 0) FROM BOOKS) AS TotalBuku,
                    (SELECT ISNULL(SUM(StokTersedia), 0) FROM BOOKS) AS StokTersedia,
                    (SELECT ISNULL(COUNT(*), 0) FROM PINJAMAN WHERE Status = 'Dipinjam') AS PinjamanAktif,
                    (SELECT ISNULL(COUNT(*), 0) FROM PINJAMAN WHERE TanggalJatuhTempo < GETDATE() AND TanggalKembali IS NULL) AS BukuTerlambat";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        metrics.TotalBuku = reader.GetInt32(0);
                        metrics.StokTersedia = reader.GetInt32(1);
                        metrics.PinjamanAktif = reader.GetInt32(2);
                        metrics.BukuTerlambat = reader.GetInt32(3);
                    }
                }
            }
            return metrics;
        }

        // --- 3. Pengambilan Daftar Peminjaman Aktif (Untuk FrmHome) ---
        public List<LoanDetail> GetActiveLoans()
        {
            var loans = new List<LoanDetail>();
            string query = @"
                SELECT  
                    B.Judul, M.NamaLengkap, P.TanggalPinjam, P.TanggalJatuhTempo
                FROM PINJAMAN P
                JOIN BOOKS B ON P.BookID = B.BookID
                JOIN MEMBERS M ON P.MemberID = M.MemberID
                WHERE P.Status = 'Dipinjam' OR P.TanggalKembali IS NULL  
                ORDER BY P.TanggalJatuhTempo ASC";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime dueDate = reader.GetDateTime(3);
                        int daysLate = 0;
                        if (dueDate < DateTime.Today) daysLate = (DateTime.Today - dueDate).Days;

                        loans.Add(new LoanDetail
                        {
                            JudulBuku = reader.GetString(0),
                            NamaPeminjam = reader.GetString(1),
                            TanggalPinjam = reader.GetDateTime(2),
                            TanggalJatuhTempo = dueDate,
                            HariTerlambat = daysLate
                        });
                    }
                }
            }
            return loans;
        }

        // --- 4. CRUD Operasi Buku (Untuk FrmBuku) ---

        // CREATE: Menambah Buku Baru
        public void AddBuku(Buku buku)
        {
            // PENTING: Ganti TblBuku jika nama tabel Anda berbeda
            string query = @"
                INSERT INTO BOOKS (Judul, Penulis, ISBN, Stok)
                VALUES (@Judul, @Penulis, @ISBN, @Stok)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Judul", buku.Judul);
                command.Parameters.AddWithValue("@Penulis", buku.Penulis);
                command.Parameters.AddWithValue("@ISBN", buku.ISBN);
                command.Parameters.AddWithValue("@Stok", buku.Stok);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // READ: Mendapatkan Semua Buku
        public List<Buku> GetAllBuku()
        {
            List<Buku> daftarBuku = new List<Buku>();
            string query = "SELECT BookID, Judul, Penulis, ISBN, Stok FROM BOOKS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Buku buku = new Buku
                    {
                        BukuID = reader.GetInt32(0),
                        Judul = reader.GetString(1),
                        Penulis = reader.GetString(2),
                        ISBN = reader.GetString(3),
                        Stok = reader.GetInt32(4)
                    };
                    daftarBuku.Add(buku);
                }
            }
            return daftarBuku;
        }

        // UPDATE: Memperbarui Buku
        public void UpdateBuku(Buku buku)
        {
            string query = @"
                UPDATE BOOKS 
                SET Judul = @Judul, Penulis = @Penulis, ISBN = @ISBN, Stok = @Stok
                WHERE BookID = @BukuID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Judul", buku.Judul);
                command.Parameters.AddWithValue("@Penulis", buku.Penulis);
                command.Parameters.AddWithValue("@ISBN", buku.ISBN);
                command.Parameters.AddWithValue("@Stok", buku.Stok);
                command.Parameters.AddWithValue("@BukuID", buku.BukuID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // DELETE: Menghapus Buku
        public void DeleteBuku(int bukuId)
        {
            string query = "DELETE FROM BOOKS WHERE BookID = @BukuID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BukuID", bukuId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Catatan: Anda perlu menambahkan metode CRUD untuk Anggota/Member di sini nanti.
    }
}