using System;

namespace Library1.Model
{
    // Model untuk metrik dashboard Home
    public class LibraryMetrics
    {
        public int TotalBuku { get; set; }
        public int StokTersedia { get; set; }
        public int PinjamanAktif { get; set; }
        public int BukuTerlambat { get; set; }
    }

    // Model untuk detail peminjaman aktif di dashboard (list buku, nama peminjam)
    public class LoanDetail
    {
        public string JudulBuku { get; set; }
        public string NamaPeminjam { get; set; }
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalJatuhTempo { get; set; }
        public int HariTerlambat { get; set; }
    }

    // Model untuk koleksi buku (untuk FrmBooks)
    public class Book
    {
        public int BookID { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int TotalStok { get; set; }
        public int StokTersedia { get; set; }
    }

    // Model untuk Anggota (Members)
    public class Member
    {
        public int MemberID { get; set; }
        public string NamaLengkap { get; set; }
        public string Kelas { get; set; }
        public string NomorHP { get; set; }
    }
}

// --- File: Model/Buku.cs ---

namespace Library1.Model
{
    public class Buku
    {
        public int BukuID { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string ISBN { get; set; }
        public int Stok { get; set; }
    }
}