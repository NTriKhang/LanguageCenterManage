﻿using LanguageCenterManage.Controls;
using LanguageCenterManage.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage
{
    public partial class EmployeeDashboard : Dashboard
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }
        public void showControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);
        }
        public void clearControl(Control control)
        {
            Content.Controls.Clear();
        }
        private void Navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.LightSteelBlue;
        }

        private void btnMStudent_MouseEnter(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.Blue;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentControl studentCtr = new StudentControl();
            showControl(studentCtr);
        }

        private void btnSwitchDashboard_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            string RoleIdUser = dbContext.Users
                .Where(m => m.Id == USER.UserId)
                .Select(m => m.RoleId).FirstOrDefault();
            string RoleIdManager = dbContext.Roles
                .Where(m => m.Name == utility.Manager)
                .Select(m => m.Id).FirstOrDefault();
            if(RoleIdUser == RoleIdManager)
            {
                ManagerDashboard MDashboard = new ManagerDashboard();
                MDashboard.Show();
                MDashboard.MdiParent = this.MdiParent;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền !", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}