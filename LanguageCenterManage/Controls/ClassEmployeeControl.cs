using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Models;
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
    public partial class ClassEmployeeControl : UserControl
    {
        AppDbContext db = new AppDbContext();
        public ClassEmployeeControl()
        {
            InitializeComponent();
        }
        public void LoadClass()
        {
            db = new AppDbContext();
            classDTOBindingSource.DataSource = db.Classes
                                                    .Include(nameof(Class.Course))
                                                    .Select(x => new ClassDTO
                                                    {
                                                        Id = x.Id,
                                                        CourseName = x.Course.Name,
                                                        Quantity = x.Quantity
                                                    }).ToList();
        }

        private void ClassEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadClass();
        }
    }
}
