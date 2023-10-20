using LanguageCenterManage.Controls;
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
    public partial class ManagerDashboard : Dashboard
    {
        public ManagerDashboard()
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseControl courseControl = new CourseControl();
            showControl(courseControl);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            LanguageControl languageControl = new LanguageControl();
            showControl(languageControl);
        }
    }
}
