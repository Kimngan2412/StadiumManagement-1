﻿using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;

namespace GUILayer.ChildForm
{
    public partial class FormDSKH : Form
    {
        private readonly CustomerRepository _db;
        public FormDSKH()
        {
            _db = new CustomerRepository();
            InitializeComponent();
            dgvDSKH.FormatTable();
            LoadData();
        }

        private void LoadData()
        {
            dgvDSKH.DataSource = _db.GetList();
            dgvDSKH.Columns["Id"].Visible = false;
        }

        private void dgvDSKH_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSKH.SelectedRows;
            if (r.Count == 1)
            {
                txtTenKhachHang.Text = r[0].Cells["Name"].Value.ToString();
                txtDiaChi.Text = r[0].Cells["Address"].Value.ToString();
                txtSoDienThoai.Text = r[0].Cells["PhoneNumber"].Value.ToString();
                bool gender = Convert.ToBoolean(r[0].Cells["Gender"].Value);
                if (gender)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _db.AddCustomer(new CustomerVM
            {
                Name = txtTenKhachHang.Text,
                Gender = rdbNam.Checked ? true : false,
                Address = txtDiaChi.Text,
                PhoneNumber = txtSoDienThoai.Text
            });
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSKH.SelectedRows;
            _db.UpdateCustomer(new CustomerVM
            {
                Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                Name = txtTenKhachHang.Text,
                Gender = rdbNam.Checked ? true : false,
                Address = txtDiaChi.Text,
                PhoneNumber = txtSoDienThoai.Text
            });
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewSelectedRowCollection r = dgvDSKH.SelectedRows;
                    if (r.Count > 0)
                    {
                        foreach(DataGridViewRow row in r)
                        {
                            _db.DeleteCustomer(Convert.ToInt32(row.Cells["Id"].Value));
                        }
                    }
                }
                LoadData();
            }
        }
    }
}