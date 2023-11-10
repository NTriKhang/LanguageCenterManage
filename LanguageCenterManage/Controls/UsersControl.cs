using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Controls
{
    public partial class UsersControl : UserControl
    {
        private AppDbContext _db;
        public UsersControl()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            _db = new AppDbContext();
            var listUser = _db.Users.Select(x => new UserDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone = x.Phone,
            }).ToList();
            userDTOBindingSource.DataSource = listUser;
        }
        private void UsersControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void UserDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
            dataGridView1.Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm();
            userDetailForm.FormClosed += UserDetailForm_FormClosed;
            userDetailForm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var userSelectedId = (userDTOBindingSource.DataSource as List<UserDTO>).ElementAtOrDefault(e.RowIndex).Id;

            UserDetailForm userDetailForm = new UserDetailForm(userSelectedId);
            userDetailForm.FormClosed += UserDetailForm_FormClosed;
            userDetailForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stringSearch = txtSearch.Text.Trim();
            if(stringSearch.Length == 0)
            {
                MessageBox.Show("Lack of information", "404", MessageBoxButtons.OK);
            }
            else
            {
                var userDtos = _db.Users.Where(x => x.Id.Contains(stringSearch) ||
                x.FirstName.Contains(stringSearch) ||
                x.LastName.Contains(stringSearch))
                .Select(x => new UserDTO
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Phone = x.Phone,
                })
                .ToList();
                userDTOBindingSource.DataSource = userDtos;
            }
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == "Enter Id, FirstName, Phone")
            {
                txtSearch.Clear();
            }
        }
    }
}
