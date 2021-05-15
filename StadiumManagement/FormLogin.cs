﻿using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormLogin : Form
    {
        private readonly AccountRepository _db;
        public static int currentAccount_Id;
        public FormLogin()
        {
            InitializeComponent();
            _db = new AccountRepository();
            btnHidePass.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string un = txtUser.Text;
            string pw = txtPass.Text;
            currentAccount_Id = _db.Authentication(un, pw);
            if (currentAccount_Id > 0)
            {
                FormControl fc = new FormControl();
                this.Hide();
                fc.ShowDialog();
                this.Show();
                txtUser.Text = "Tài khoản";
                txtPass.Text = "Mật khẩu";
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            btnHidePass.Hide();
            btnShowPass.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            btnShowPass.Hide();
            btnHidePass.Show();
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
