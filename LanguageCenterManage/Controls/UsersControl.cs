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
        List<UserDTO> ListUser;
        public UsersControl()
        {
            InitializeComponent();
            ListUser = new List<UserDTO>();
        }
        private void LoadData()
        {
            _db = new AppDbContext();
            ListUser = _db.Users.Select(x => new UserDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone = x.Phone,
            }).ToList();
            userDTOBindingSource.DataSource = ListUser;
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
            if(stringSearch != null)
            {
                ListUser = _db.Users.Where(x => x.Id.Contains(stringSearch) ||
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
                userDTOBindingSource.DataSource = ListUser;
                SortDG(Sort_Combobox.SelectedItem.ToString());
            }
            else
            {
                LoadData();
            }
        }
        public void SortDG(string value)
        {
            string stringSort = Sort_Combobox.Text;
            if (!string.IsNullOrEmpty(stringSort))
            {
                ListUser = ListUser.OrderBy(x => x.GetType()
                                                  .GetProperty(value)
                                                  .GetValue(x, null)).ToList();
                dataGridView1.DataSource = ListUser;
            }
            else
            {
                LoadData();
            }
        }
        private void Sort_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortDG(Sort_Combobox.SelectedItem.ToString());
        }
    }
}
