﻿
namespace GUILayer
{
    partial class FormControl
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
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnStatistic = new FontAwesome.Sharp.IconButton();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.btnDSKH = new System.Windows.Forms.Button();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.pnlCashier = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnDSNV = new System.Windows.Forms.Button();
            this.btnCashier = new FontAwesome.Sharp.IconButton();
            this.pnlService = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnService = new FontAwesome.Sharp.IconButton();
            this.pnlStadium = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSanBong = new System.Windows.Forms.Button();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnStadium = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconZoom = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.lblCurrentForm = new System.Windows.Forms.Label();
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDMY = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlCashier.SuspendLayout();
            this.pnlService.SuspendLayout();
            this.pnlStadium.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.btnStatistic);
            this.PanelMenu.Controls.Add(this.pnlCustomer);
            this.PanelMenu.Controls.Add(this.btnCustomer);
            this.PanelMenu.Controls.Add(this.pnlCashier);
            this.PanelMenu.Controls.Add(this.btnCashier);
            this.PanelMenu.Controls.Add(this.pnlService);
            this.PanelMenu.Controls.Add(this.btnService);
            this.PanelMenu.Controls.Add(this.pnlStadium);
            this.PanelMenu.Controls.Add(this.btnSetting);
            this.PanelMenu.Controls.Add(this.btnLogOut);
            this.PanelMenu.Controls.Add(this.btnStadium);
            this.PanelMenu.Controls.Add(this.pnlLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(170, 675);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistic.IconChar = FontAwesome.Sharp.IconChar.Apple;
            this.btnStatistic.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStatistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistic.IconSize = 35;
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(0, 554);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStatistic.Size = new System.Drawing.Size(170, 50);
            this.btnStatistic.TabIndex = 16;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.Indigo;
            this.pnlCustomer.Controls.Add(this.button11);
            this.pnlCustomer.Controls.Add(this.btnDSKH);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomer.ForeColor = System.Drawing.Color.White;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 486);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(170, 68);
            this.pnlCustomer.TabIndex = 15;
            this.pnlCustomer.Visible = false;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Gainsboro;
            this.button11.Location = new System.Drawing.Point(0, 33);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(170, 32);
            this.button11.TabIndex = 1;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnDSKH
            // 
            this.btnDSKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSKH.FlatAppearance.BorderSize = 0;
            this.btnDSKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDSKH.Location = new System.Drawing.Point(0, 0);
            this.btnDSKH.Name = "btnDSKH";
            this.btnDSKH.Size = new System.Drawing.Size(170, 33);
            this.btnDSKH.TabIndex = 0;
            this.btnDSKH.Text = "DS Khách hàng";
            this.btnDSKH.UseVisualStyleBackColor = true;
            this.btnDSKH.Click += new System.EventHandler(this.btnDSKH_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.Skull;
            this.btnCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.IconSize = 35;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 436);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomer.Size = new System.Drawing.Size(170, 50);
            this.btnCustomer.TabIndex = 14;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlCashier
            // 
            this.pnlCashier.BackColor = System.Drawing.Color.Indigo;
            this.pnlCashier.Controls.Add(this.btnTaiKhoan);
            this.pnlCashier.Controls.Add(this.btnDSNV);
            this.pnlCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCashier.ForeColor = System.Drawing.Color.White;
            this.pnlCashier.Location = new System.Drawing.Point(0, 361);
            this.pnlCashier.Name = "pnlCashier";
            this.pnlCashier.Size = new System.Drawing.Size(170, 75);
            this.pnlCashier.TabIndex = 13;
            this.pnlCashier.Visible = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 37);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(170, 34);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "DS Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnDSNV
            // 
            this.btnDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSNV.FlatAppearance.BorderSize = 0;
            this.btnDSNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDSNV.Location = new System.Drawing.Point(0, 0);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(170, 37);
            this.btnDSNV.TabIndex = 0;
            this.btnDSNV.Text = "DS Nhân viên";
            this.btnDSNV.UseVisualStyleBackColor = true;
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCashier.IconChar = FontAwesome.Sharp.IconChar.Spider;
            this.btnCashier.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCashier.IconSize = 35;
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.Location = new System.Drawing.Point(0, 311);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCashier.Size = new System.Drawing.Size(170, 50);
            this.btnCashier.TabIndex = 12;
            this.btnCashier.Text = "Nhân viên";
            this.btnCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // pnlService
            // 
            this.pnlService.BackColor = System.Drawing.Color.Indigo;
            this.pnlService.Controls.Add(this.button5);
            this.pnlService.Controls.Add(this.btnDichVu);
            this.pnlService.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlService.ForeColor = System.Drawing.Color.White;
            this.pnlService.Location = new System.Drawing.Point(0, 240);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(170, 71);
            this.pnlService.TabIndex = 11;
            this.pnlService.Visible = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(0, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDichVu.Location = new System.Drawing.Point(0, 0);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(170, 35);
            this.btnDichVu.TabIndex = 0;
            this.btnDichVu.Text = "Quản lý dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnService.IconChar = FontAwesome.Sharp.IconChar.StackOverflow;
            this.btnService.IconColor = System.Drawing.Color.Gainsboro;
            this.btnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnService.IconSize = 35;
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(0, 190);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnService.Size = new System.Drawing.Size(170, 50);
            this.btnService.TabIndex = 10;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // pnlStadium
            // 
            this.pnlStadium.BackColor = System.Drawing.Color.Indigo;
            this.pnlStadium.Controls.Add(this.button2);
            this.pnlStadium.Controls.Add(this.btnSanBong);
            this.pnlStadium.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStadium.ForeColor = System.Drawing.Color.White;
            this.pnlStadium.Location = new System.Drawing.Point(0, 120);
            this.pnlStadium.Name = "pnlStadium";
            this.pnlStadium.Size = new System.Drawing.Size(170, 70);
            this.pnlStadium.TabIndex = 9;
            this.pnlStadium.Visible = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(0, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSanBong
            // 
            this.btnSanBong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanBong.FlatAppearance.BorderSize = 0;
            this.btnSanBong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanBong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanBong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSanBong.Location = new System.Drawing.Point(0, 0);
            this.btnSanBong.Name = "btnSanBong";
            this.btnSanBong.Size = new System.Drawing.Size(170, 36);
            this.btnSanBong.TabIndex = 0;
            this.btnSanBong.Text = "Quản lý sân";
            this.btnSanBong.UseVisualStyleBackColor = true;
            this.btnSanBong.Click += new System.EventHandler(this.btnSanBong_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 35;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 575);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(170, 50);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 35;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 625);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogOut.Size = new System.Drawing.Size(170, 50);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnStadium
            // 
            this.btnStadium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStadium.FlatAppearance.BorderSize = 0;
            this.btnStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStadium.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStadium.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnStadium.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStadium.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStadium.IconSize = 35;
            this.btnStadium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStadium.Location = new System.Drawing.Point(0, 70);
            this.btnStadium.Name = "btnStadium";
            this.btnStadium.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStadium.Size = new System.Drawing.Size(170, 50);
            this.btnStadium.TabIndex = 1;
            this.btnStadium.Text = "Sân bóng";
            this.btnStadium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStadium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStadium.UseVisualStyleBackColor = true;
            this.btnStadium.Click += new System.EventHandler(this.btnStadium_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(170, 70);
            this.pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUILayer.Properties.Resources.phuocleoceo;
            this.picLogo.Location = new System.Drawing.Point(55, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelTitlebar.Controls.Add(this.lblDateTime);
            this.panelTitlebar.Controls.Add(this.lblUserName);
            this.panelTitlebar.Controls.Add(this.iconMinimize);
            this.panelTitlebar.Controls.Add(this.iconZoom);
            this.panelTitlebar.Controls.Add(this.iconExit);
            this.panelTitlebar.Controls.Add(this.lblCurrentForm);
            this.panelTitlebar.Controls.Add(this.iconCurrentForm);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(170, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(1057, 70);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDateTime.Location = new System.Drawing.Point(366, 31);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(71, 20);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "12:30:33";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(184, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 16);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "phuocleoceo";
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(959, 2);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(30, 30);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconZoom
            // 
            this.iconZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconZoom.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconZoom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconZoom.IconSize = 25;
            this.iconZoom.Location = new System.Drawing.Point(994, 7);
            this.iconZoom.Name = "iconZoom";
            this.iconZoom.Size = new System.Drawing.Size(30, 30);
            this.iconZoom.TabIndex = 3;
            this.iconZoom.UseVisualStyleBackColor = true;
            this.iconZoom.Click += new System.EventHandler(this.iconZoom_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(1022, 7);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(30, 30);
            this.iconExit.TabIndex = 2;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // lblCurrentForm
            // 
            this.lblCurrentForm.AutoSize = true;
            this.lblCurrentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentForm.Location = new System.Drawing.Point(64, 31);
            this.lblCurrentForm.Name = "lblCurrentForm";
            this.lblCurrentForm.Size = new System.Drawing.Size(45, 16);
            this.lblCurrentForm.TabIndex = 1;
            this.lblCurrentForm.Text = "Home";
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentForm.Location = new System.Drawing.Point(19, 23);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentForm.TabIndex = 0;
            this.iconCurrentForm.TabStop = false;
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelshadow.Location = new System.Drawing.Point(173, 64);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(628, 9);
            this.panelshadow.TabIndex = 2;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlChildForm.BackgroundImage = global::GUILayer.Properties.Resources.IMG_0487;
            this.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChildForm.Controls.Add(this.lblDate);
            this.pnlChildForm.Controls.Add(this.lblDMY);
            this.pnlChildForm.Controls.Add(this.lblTime);
            this.pnlChildForm.Location = new System.Drawing.Point(170, 70);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1057, 605);
            this.pnlChildForm.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(588, 333);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(267, 73);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Monday";
            // 
            // lblDMY
            // 
            this.lblDMY.AutoSize = true;
            this.lblDMY.BackColor = System.Drawing.Color.Transparent;
            this.lblDMY.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMY.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDMY.Location = new System.Drawing.Point(56, 333);
            this.lblDMY.Name = "lblDMY";
            this.lblDMY.Size = new System.Drawing.Size(366, 73);
            this.lblDMY.TabIndex = 8;
            this.lblDMY.Text = "05/06/2001";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(305, 166);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(425, 108);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "10:08:01";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 675);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainControl";
            this.PanelMenu.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCashier.ResumeLayout(false);
            this.pnlService.ResumeLayout(false);
            this.pnlStadium.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnStadium;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        private System.Windows.Forms.Label lblCurrentForm;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconZoom;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDMY;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlStadium;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSanBong;
        private FontAwesome.Sharp.IconButton btnService;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnDSKH;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private System.Windows.Forms.Panel pnlCashier;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDSNV;
        private FontAwesome.Sharp.IconButton btnCashier;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDichVu;
        private FontAwesome.Sharp.IconButton btnStatistic;
    }
}