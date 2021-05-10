﻿using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;

namespace GUILayer.ChildForm
{
    public partial class FormDatDichVu : Form
    {
        private readonly ServiceOrderRepository _db;
        public FormDatDichVu()
        {
            InitializeComponent();
            dgvDV.FormatTable();
            _db = new ServiceOrderRepository();
            LoadData();
            _db.LoadComboBoxBill(cbbHoaDon);
        }

        private void LoadData()
        {
            dgvDV.DataSource = null;
            dgvDV.Rows.Clear();
            dgvDV.DataSource = _db.GetList();
            dgvDV.Columns["Id"].Visible = false;
            dgvDV.Columns["Service_Image"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = cbbHoaDon.Text = "";
            NUDSoLuong.Value = 0;
            lblDichVu.Text = "Click to choose ...";
            picDV.Image = null;
        }

        private void dgvDV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDV.SelectedRows;
            if (r.Count == 1)
            {
                cbbHoaDon.Text = r[0].Cells["Bill_Code"].Value.ToString();
                NUDSoLuong.Value = Convert.ToDecimal(r[0].Cells["Count"].Value);
                txtTongTien.Text = r[0].Cells["Total"].Value.ToString();
                lblDichVu.Text = r[0].Cells["Service_Name"].Value.ToString();
                picDV.Image = ((byte[])(r[0].Cells["Service_Image"].Value)).ByteArrayToImage();
            }
        }

        private void picDV_Click(object sender, EventArgs e)
        {

        }
    }
}