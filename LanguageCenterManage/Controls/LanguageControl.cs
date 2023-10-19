using LanguageCenterManage.DAL;
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
    public partial class LanguageControl : UserControl
    {
        private readonly AppDbContext _db;
        public LanguageControl()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void LanguageControl_Load(object sender, EventArgs e)
        {
            var listLanguage = _db.Languages.Select(x => new Language
            {
                Id = x.Id,
                Name = x.Name,
            });
            languageBindingSource.DataSource = listLanguage;
        }
    }
}
