namespace Library1
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTotalBuku = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuBuku = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnggota = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalBuku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStokTersedia = new System.Windows.Forms.Panel();
            this.lblStokTersedia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBukuTerlambat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBukuTerlambat = new System.Windows.Forms.Panel();
            this.lblPinjamanAktif = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPinjamanAktif = new System.Windows.Forms.Panel();
            this.dgActiveLoans = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgActiveLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotalBuku
            // 
            this.panelTotalBuku.BackColor = System.Drawing.Color.LightGreen;
            this.panelTotalBuku.Location = new System.Drawing.Point(74, 104);
            this.panelTotalBuku.Name = "panelTotalBuku";
            this.panelTotalBuku.Size = new System.Drawing.Size(200, 100);
            this.panelTotalBuku.TabIndex = 0;
            this.panelTotalBuku.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTotalBuku_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBuku,
            this.MenuAnggota,
            this.MenuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuBuku
            // 
            this.MenuBuku.Name = "MenuBuku";
            this.MenuBuku.Size = new System.Drawing.Size(55, 24);
            this.MenuBuku.Text = "Buku";
            this.MenuBuku.Click += new System.EventHandler(this.MenuBuku_Click_1);
            // 
            // MenuAnggota
            // 
            this.MenuAnggota.Name = "MenuAnggota";
            this.MenuAnggota.Size = new System.Drawing.Size(81, 24);
            this.MenuAnggota.Text = "Anggota";
            this.MenuAnggota.Click += new System.EventHandler(this.MenuAnggota_Click);
            // 
            // MenuLogout
            // 
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(76, 24);
            this.MenuLogout.Text = "Log Out";
            this.MenuLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblTotalBuku
            // 
            this.lblTotalBuku.AutoSize = true;
            this.lblTotalBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalBuku.Location = new System.Drawing.Point(147, 215);
            this.lblTotalBuku.Name = "lblTotalBuku";
            this.lblTotalBuku.Size = new System.Drawing.Size(27, 29);
            this.lblTotalBuku.TabIndex = 2;
            this.lblTotalBuku.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(110, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Buku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelStokTersedia
            // 
            this.panelStokTersedia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelStokTersedia.Location = new System.Drawing.Point(301, 104);
            this.panelStokTersedia.Name = "panelStokTersedia";
            this.panelStokTersedia.Size = new System.Drawing.Size(200, 100);
            this.panelStokTersedia.TabIndex = 1;
            this.panelStokTersedia.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStokTersedia_Paint);
            // 
            // lblStokTersedia
            // 
            this.lblStokTersedia.AutoSize = true;
            this.lblStokTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblStokTersedia.Location = new System.Drawing.Point(323, 61);
            this.lblStokTersedia.Name = "lblStokTersedia";
            this.lblStokTersedia.Size = new System.Drawing.Size(169, 29);
            this.lblStokTersedia.TabIndex = 5;
            this.lblStokTersedia.Text = "Stok Tersedia";
            this.lblStokTersedia.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(381, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBukuTerlambat
            // 
            this.lblBukuTerlambat.AutoSize = true;
            this.lblBukuTerlambat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBukuTerlambat.Location = new System.Drawing.Point(771, 61);
            this.lblBukuTerlambat.Name = "lblBukuTerlambat";
            this.lblBukuTerlambat.Size = new System.Drawing.Size(192, 29);
            this.lblBukuTerlambat.TabIndex = 8;
            this.lblBukuTerlambat.Text = "Buku Terlambat";
            this.lblBukuTerlambat.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(844, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // panelBukuTerlambat
            // 
            this.panelBukuTerlambat.BackColor = System.Drawing.Color.Orange;
            this.panelBukuTerlambat.Location = new System.Drawing.Point(752, 104);
            this.panelBukuTerlambat.Name = "panelBukuTerlambat";
            this.panelBukuTerlambat.Size = new System.Drawing.Size(200, 100);
            this.panelBukuTerlambat.TabIndex = 6;
            // 
            // lblPinjamanAktif
            // 
            this.lblPinjamanAktif.AutoSize = true;
            this.lblPinjamanAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPinjamanAktif.Location = new System.Drawing.Point(551, 61);
            this.lblPinjamanAktif.Name = "lblPinjamanAktif";
            this.lblPinjamanAktif.Size = new System.Drawing.Size(177, 29);
            this.lblPinjamanAktif.TabIndex = 11;
            this.lblPinjamanAktif.Text = "Pinjaman Aktif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(614, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "0";
            // 
            // panelPinjamanAktif
            // 
            this.panelPinjamanAktif.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPinjamanAktif.Location = new System.Drawing.Point(528, 104);
            this.panelPinjamanAktif.Name = "panelPinjamanAktif";
            this.panelPinjamanAktif.Size = new System.Drawing.Size(200, 100);
            this.panelPinjamanAktif.TabIndex = 9;
            // 
            // dgActiveLoans
            // 
            this.dgActiveLoans.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgActiveLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActiveLoans.Location = new System.Drawing.Point(74, 328);
            this.dgActiveLoans.Name = "dgActiveLoans";
            this.dgActiveLoans.RowHeadersWidth = 51;
            this.dgActiveLoans.RowTemplate.Height = 24;
            this.dgActiveLoans.Size = new System.Drawing.Size(453, 300);
            this.dgActiveLoans.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(196, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tabel Peminjaman Aktif";
            // 
            // FrmHome
            // 
            this.ClientSize = new System.Drawing.Size(1058, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgActiveLoans);
            this.Controls.Add(this.lblPinjamanAktif);
            this.Controls.Add(this.lblBukuTerlambat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelPinjamanAktif);
            this.Controls.Add(this.panelBukuTerlambat);
            this.Controls.Add(this.lblStokTersedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelStokTersedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalBuku);
            this.Controls.Add(this.panelTotalBuku);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load_2);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgActiveLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelTotalBuku;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBuku;
        private System.Windows.Forms.ToolStripMenuItem MenuAnggota;
        private System.Windows.Forms.ToolStripMenuItem MenuLogout;
        private System.Windows.Forms.Label lblTotalBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStokTersedia;
        private System.Windows.Forms.Label lblStokTersedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBukuTerlambat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelBukuTerlambat;
        private System.Windows.Forms.Label lblPinjamanAktif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelPinjamanAktif;
        private System.Windows.Forms.DataGridView dgActiveLoans;
        private System.Windows.Forms.Label label2;

        #endregion

        // JANGAN ADA DEKLARASI VARIABEL KOMPONEN DI SINI DULU!
    }
}