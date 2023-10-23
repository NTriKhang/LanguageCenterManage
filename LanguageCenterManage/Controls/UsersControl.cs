using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
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
            
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
