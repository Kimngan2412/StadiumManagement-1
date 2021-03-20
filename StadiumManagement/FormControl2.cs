﻿using System;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormControl2 : Form
    {
        public FormControl2()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        #region Design
        private void CustomizeDesign()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            pnlManage.Visible = false;
            pnlSetting.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlManage.Visible == true) pnlManage.Visible = false;
            if (pnlSetting.Visible == true) pnlSetting.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion

        #region FormProcess
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region ClickButton
        private void btnManage_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlManage);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());
            HideSubMenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSetting);
        }
        #endregion
    }
}