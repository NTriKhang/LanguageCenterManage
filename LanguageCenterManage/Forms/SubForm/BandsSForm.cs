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

namespace LanguageCenterManage.Forms.SubForm
{
    public partial class BandsSForm : Form
    {
        public List<BandDTO> Bands;
        public BandsSForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bands = bandDTOBindingSource.DataSource as List<BandDTO>;
            Close();
        }

        private void BandsSForm_Load(object sender, EventArgs e)
        {
            bandDTOBindingSource.DataSource = new List<BandDTO>();
        }
    }
}
