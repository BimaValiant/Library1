using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Library1
{
    partial class Login
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
            pnlSidebar = new System.Windows.Forms.Panel();
            lblAppTitle = new System.Windows.Forms.Label();
            lblLoginTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            pnlSidebar.Controls.Add(lblAppTitle);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(250, 520);
            pnlSidebar.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAppTitle.ForeColor = System.Drawing.Color.White;
            lblAppTitle.Location = new System.Drawing.Point(0, 188);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new System.Drawing.Size(250, 94);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "📚 Library App";
            lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLoginTitle.Location = new System.Drawing.Point(280, 62);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new System.Drawing.Size(127, 54);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUsername.Location = new System.Drawing.Point(285, 150);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(87, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtUsername.Location = new System.Drawing.Point(289, 181);
            txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(380, 34);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPassword.Location = new System.Drawing.Point(285, 244);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(80, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtPassword.Location = new System.Drawing.Point(289, 275);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(380, 34);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(289, 362);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(380, 62);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "MASUK";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(698, 520);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLoginTitle);
            Controls.Add(pnlSidebar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login Aplikasi Perpustakaan";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}