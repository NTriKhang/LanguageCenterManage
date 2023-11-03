using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCenterManage.Services.Kmean;

namespace LanguageCenterManage.Controls
{
    public partial class StatisticControl : UserControl
    {
        public StatisticControl()
        {
            InitializeComponent();
        }

        private void KmeanBtn_Click(object sender, EventArgs e)
        {
            KmeanForm kmeanForm = new KmeanForm();  
            kmeanForm.ShowDialog();
        }
    }
}
