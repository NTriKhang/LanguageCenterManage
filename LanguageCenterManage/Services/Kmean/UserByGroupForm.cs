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

namespace LanguageCenterManage.Services.Kmean
{
    public partial class UserByGroupForm : Form
    {
        List<UserDTO> users = new List<UserDTO>();
        public UserByGroupForm(List<UserDTO> users)
        {
            this.users = users; 
            InitializeComponent();
        }

        private void UserByGroupForm_Load(object sender, EventArgs e)
        {
            userDTOBindingSource.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
